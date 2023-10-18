
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

using YandexDisk.Client.Http;


namespace TelegramBotExperiments
{

    class Program
    {//y0_AgAAAAArxDRgAAh0tAAAAADQB0utJZyIDNlIQraxsR0_LwmAUCUxoeo

        static DiskHttpApi api = new DiskHttpApi("y0_AgAAAAArxDRgAAh0tAAAAADQB0utJZyIDNlIQraxsR0_LwmAUCUxoeo");
        static ITelegramBotClient bot = new TelegramBotClient("5337023432:AAGRvLKKKtqFrCmFW3SMUJjN7Hph3xQA8EA");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Telegram.Bot.Types.Update update, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            var message = update.Message;

            if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                ReplyKeyboardMarkup keyboard = new(new[]
                {
                    new KeyboardButton[] {"Перевозки", "Отчет"},
                })
                {
                    ResizeKeyboard = true
                };

                if (message.Text == "Перевозки")
                {
                   Uploud();
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Загружено");
                    return;
                }
                if (message.Text == "Отчет")
                {
                   Uploud2();
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Отправлено");
                    return;
                }
                await botClient.SendTextMessageAsync(message.Chat.Id, "Choose:", replyMarkup: keyboard);
            }
            if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Document)//обработка документов
            {
                Console.WriteLine(update.Message.Document.FileId);
                Console.WriteLine(update.Message.Document.FileName);
                Console.WriteLine($"Объем файла: {update.Message.Document.FileSize}");
                DownLoad(update.Message.Document.FileId, message.Document.FileName);
                await botClient.SendTextMessageAsync(message.Chat, $"Документ:{message.Document.FileName} скачан");
                return;
            }


            if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Photo)//обработка фото
            {
                Console.WriteLine($"Объем фото: {update.Message.Photo.Length}");
                Console.WriteLine($"Айди фотографии: {message.Photo[message.Photo.Length - 1].FileId}");
                DownLoad2(message.Photo[message.Photo.Length - 1].FileId, "фотография");
                await botClient.SendTextMessageAsync(message.Chat, "Фото скачано");
                return;
            }
            if (update.Message.Type == Telegram.Bot.Types.Enums.MessageType.Video)//обработка видео
            {
                Console.WriteLine($"Название видео: {update.Message.Video.FileName}");
                Console.WriteLine($"Айди видео: {update.Message.Video.FileId}");
                Console.WriteLine($"Длина видео: {update.Message.Video.Duration}");
                Console.WriteLine($"Объем видео: {update.Message.Video.FileSize}");
                Console.WriteLine($"Формат видео: {update.Message.Video.Width}р");
                DownLoad2(update.Message.Video.FileId, update.Message.Video.FileName);
                await botClient.SendTextMessageAsync(message.Chat, "Видео загружено");
                return;
            }

        }


      
        //вывод ошибок
        static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var ErrorMessage = exception switch
            {
                ApiRequestException apiRequestException
                    => $"Ошибка телеграм АПИ:\n{apiRequestException.ErrorCode}\n{apiRequestException.Message}",
                _ => exception.ToString()
            };
            Console.WriteLine(ErrorMessage);
            return Task.CompletedTask;

        }
        static async void DownLoad(string fileId, string path)//скачивание файла для последующей конвертации и отправки на яндекс диск
        {
          
            var file = await bot.GetFileAsync(fileId);
            FileStream fs = new FileStream(@"Download/" + fileId, FileMode.Create);
            await bot.DownloadFileAsync(file.FilePath, fs);
            fs.Close();
            fs.Dispose();
            if (file.FilePath.Contains(".zip") != true)
            {
                ConvertToZip(path);
            }
        }

        private static void ConvertToZip(string path)//перевод файлов в формат zip
        {
            using (var fileStream = new FileStream(@"Download/ПЕРЕВОЗКИ.zip", FileMode.Create))
            {
                using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(@"Download/"+path,path);
                   
                }
            }
            System.IO.File.Delete(path);
        }
        static async void DownLoad2(string fileId, string path)//скачивание файла для последующей конвертации и отправки на яндекс диск
        {

            var file = await bot.GetFileAsync(fileId);
           
                FileStream fs = new FileStream(@"Download/" + path, FileMode.Create);
                await bot.DownloadFileAsync(file.FilePath, fs);
                fs.Close();
                fs.Dispose();
           
        }

        static async void Uploud()// загрузка файла на яндекс диск
        {

            var files = Directory.GetFiles(@"Download/");

           
            if (files != null)
            {
                for (int i=0;i<files.Length;i++)
                {
                    if (files[i].Contains(".zip")==true)
                    { 
                            var link = await api.Files.GetUploadLinkAsync(@"/Перевозки/" + Path.GetFileName(files[i]), overwrite:true);
                        if (link == null)
                        {
                            using (var fs = System.IO.File.OpenRead(files[i]))
                            {
                                await api.Files.UploadAsync(link, fs);
                            }
                        }
                        else
                        {
                            var link2 = await api.Files.GetUploadLinkAsync(@"/Перевозки/" + Path.GetFileName(files[i] +$"{i}"), overwrite: true);
                            using (var fs = System.IO.File.OpenRead(files[i]))
                            {
                                await api.Files.UploadAsync(link2, fs);
                            }
                        }
                        System.IO.File.Delete(files[i]);

                    }
                }
            }
        }
        static async void Uploud2()// загрузка файла на яндекс диск
        {
            var files = Directory.GetFiles(@"Download/");
            if (files != null)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    var link = await api.Files.GetUploadLinkAsync(@"/Отчёт/" + Path.GetFileName(files[i]), overwrite: true);
                    if (link == null)
                    {
                        using (var fs = System.IO.File.OpenRead(files[i]))
                        {
                            await api.Files.UploadAsync(link, fs);
                        }
                    }
                    else
                    {
                        var link2 = await api.Files.GetUploadLinkAsync(@"/Отчёт/" + Path.GetFileName(files[i] + $"{i}"), overwrite: true);
                        using (var fs = System.IO.File.OpenRead(files[i]))
                        {
                            await api.Files.UploadAsync(link2, fs);
                        }
                    }
                    System.IO.File.Delete(files[i]);

                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Task.Run(() =>
                {
                    Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);
                    var cts = new CancellationTokenSource();
                    var cancellationToken = cts.Token;
                    var receiverOptions = new ReceiverOptions
                    {
                        AllowedUpdates = { }, // receive all update types
                    };
                    bot.StartReceiving(
                        HandleUpdateAsync,
                        HandleErrorAsync,
                        receiverOptions,
                        cancellationToken
                    );

                    return Task.CompletedTask;

                });
                Thread.Sleep(1000000);
            }
           
        }

    }
}