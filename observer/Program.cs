using System;
using System.Collections.Generic;
using System.IO;
using System.Timers;

namespace observer
{

    public class DirMonitoring
    {
        private List<string> _files;
        private readonly string _directory;

        public DirMonitoring(string directory)
        {
            _directory = directory;
        }

        public bool StartMonitor()
        {
            if (!Directory.Exists(_directory))
            {
                return false;
            }

            _files = new List<string>();

            var directoryInfo = new DirectoryInfo(_directory);
            foreach (var fileInfo in directoryInfo.GetFiles())
            {
                _files.Add(fileInfo.FullName);
            }

            return true;
        }

        public List<string> DeletedFiles()
        {
            var result = new List<string>();
            foreach (var file in _files.ToArray())
            {
                if (!File.Exists(file))
                {
                    _files.Remove(file);
                    result.Add(file);
                }
            }

            return result;
        }
    }
    public class Subscriber
    {
        private readonly string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        public void ItIsSubscriber(string fileName)
        {
            Console.WriteLine($"{_name} {fileName} was deleted!");
        }

        public void ItIsSubscriber(object sender, string fileName)
        {
            Console.WriteLine($"{_name} {fileName} was deleted!");
        }

        public void ItIsSecondSubscriber(object sender, string fileName)
        {
            Console.WriteLine("---");
            Console.WriteLine($"{_name} {fileName} was deleted!");
            Console.WriteLine("---");
        }
    }
    class FileStatusDelegate : IDisposable
    {
        private readonly Action<string> _subscriber;
        private readonly Timer _timer;
        private readonly DirMonitoring _dirMonitoring;

        public FileStatusDelegate(string directory, Action<string> subscriber)
        {
            _subscriber = subscriber;
            _dirMonitoring = new DirMonitoring(directory);

            if (_dirMonitoring.StartMonitor())
            {
                _timer = new Timer(1000);
                _timer.Elapsed += CheckRemoval;
                _timer.Start();
            }
            else
            {
                Console.WriteLine("Specified direcory does not exist");
                Dispose();
            }
        }

        private void CheckRemoval(Object source, ElapsedEventArgs e)
        {
            foreach (var fileName in _dirMonitoring.DeletedFiles())
            {
                _subscriber(fileName);
            }
        }

        public void Dispose()
        {
            _timer.Dispose();
        }



    }
    /// через события
     class FileStatusEvent : IDisposable
{
    public EventHandler<string> RemoveFiles;
    private readonly Timer _timer;
    private readonly DirMonitoring _dirMonitoring;

    public FileStatusEvent(string directory)
    {
        _dirMonitoring = new DirMonitoring(directory);

        if (_dirMonitoring.StartMonitor())
        {
            _timer = new Timer(1000);
            _timer.Elapsed += CheckRemoval;
            _timer.Start();
        }
        else
        {
            Console.WriteLine("Specified direcory does not exist");
            Dispose();
        }
    }

    private void CheckRemoval(Object source, ElapsedEventArgs e)
    {
        foreach (var fileName in _dirMonitoring.DeletedFiles())
        {
            var handler = RemoveFiles;
            handler?.Invoke(this, fileName);
        }
    }

    public void Dispose()
    {
        _timer.Dispose();
    }
}
}
