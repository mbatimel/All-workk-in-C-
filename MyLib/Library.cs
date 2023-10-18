using System;
using System.Collections.Generic;
using System.Collections;

public class Node<T> // Список элементов с динамические изменяемым размером, T - тип данных
{
    public Node(T data)
    {
        Data = data;
    }
    public T Data { get; set; } // Свойство для хранения данных
    public Node<T> Previous { get; set; } // Свойство для ссылки на предыдущий узел
    public Node<T> Next { get; set; } // Свойство для ссылки на следующий узел
}

namespace Library
{
    
    public class NodeStack<T> : IEnumerable<T> // IEnumerable - перечислитель внутри класса
    {
        public List<T> value = new List<T>();
        Node<T> head; // Node<T> - верхушка стека
        int count; // Кол-во элементов в списке

        public bool IsEmpty // Возвращает только правду или ложь
        {
            get { return count == 0; } // Если сработало return count == 0, то правда.
        }
        public int Count // Возвращает количество элементов
        {
            get { return count; }
        }
        public int Needtofind(T stroka)
        {
            int a = 0;
            if (stroka != null)
            {
                if (value.Contains(stroka))
                {
                    a = value.IndexOf(stroka);
                }
                else
                {
                    return -1;
                }
            }
            return a;
        }
        public void Push(T item) // Метод добавления элементов в стек
        {
            Node<T> node = new Node<T>(item); // node - новый элемент
            node.Next = head; // Следующему элементу присваивается значение head
            head = node; // новый элемент - 1-й в списке
            count++;
            value.Insert(0, item);
        }
        public T Pop() // Метод удаления верхушки стека
        {            
            if (IsEmpty) // если стек пуст, выбрасываем исключение
                throw new InvalidOperationException("Стек пуст");
            Node<T> temp = head; // temp имеет значения head для дальнейшего вывода
            head = head.Next; // переустанавливаем верхушку стека на следующий элемент
            count--;
            return temp.Data; // Возвращает значение выкинутого элемента
            value.Remove(head.Data);
        }
        public T Peek() // Метод возвращения 1-го элемента
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");
            return head.Data;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        } // Ввод перечислителя позволяет работать с foreach в коллекциях

        IEnumerator<T> IEnumerable<T>.GetEnumerator() // Перечисляет все элементы стека
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data; // итератор представляет доступ к элементу коллекции current.Data
                current = current.Next;
            }
        }
    }
    public class Deque<T> : IEnumerable<T>  // двусвязный список
    {
        public List<T> value = new List<T>();
        Node<T> head; 
        Node<T> tail; // последний/хвостовой элемент
        int count;

        public int Needtofind(T stroka)
        {
            int a = 0;
            if (stroka != null)
            {
                if (value.Contains(stroka))
                {
                    a = value.IndexOf(stroka);
                }
                else
                {
                    return -1;
                }
            }
            return a;
        }
        public void AddLast(T data) // Метод добавления элемента в конец
        {
            Node<T> node = new Node<T>(data);

            if (head == null) // Если список пуст
                head = node;
            else
            {
                tail.Next = node; // Если список не пуст, то node - последний элемент
                node.Previous = tail;
            }
            tail = node;
            count++;
            value.Add(data);
        }
        public void AddFirst(T data) // Метод добавления элемента в начало
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0) // Если список пуст
                tail = head;
            else
                temp.Previous = node;
            count++;
            value.Insert(0, tail.Data);
        }
        public T RemoveFirst() // Метод удаления 1-го элемента
        {
            if (count == 0) // Если в списке нет элементов
                throw new InvalidOperationException();
            T output = head.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            count--;
            return output; // Возвращает значение удаленного элемента
            value.Remove(head.Data);
        }
        public T RemoveLast() // Метод удаления последнего элемента
        {
            if (count == 0) // Если список пуст 
                throw new InvalidOperationException();
            T output = tail.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
            count--;
            return output;
            value.Remove(tail.Data);
        }
        public T First // Метод возвращения значения 1-го элемента
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }
        public T Last // Метод возвращения значения последнего элемента
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear() // Очистка дека
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(T data) // Проверка на существование элемента в деке
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
    public class Que<T> : IEnumerable<T>
    {
        Node<T> head; 
        Node<T> tail; 
        int count;
        public List<T> value = new List<T>();
        public int Needtofind(T stroka)
        {
            int a = 0;
            if (stroka != null)
            {
                if (value.Contains(stroka))
                {
                    a = value.IndexOf(stroka);
                }
                else
                {
                    return -1;
                }
            }
            return a;
        }
        public void Enqueue(T data) // Добавление в очередь
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
            value.Add(data);
        }       
        public T Dequeue() // удаление из очереди
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
            value.Remove(head.Data);
        }        
        public T First // получаем первый элемент
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            }
        }       
        public T Last // получаем последний элемент
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            }
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
