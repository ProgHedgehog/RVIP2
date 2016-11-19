using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _4laba
{
    public class Threads
    {
        private ChangeUI _ui;
        public Threads(ChangeUI ui)
        {
            _ui = ui;
        }
        private List<Thread> _threads;
        public void Run(int count_threads)
        {
            _threads = new List<Thread>();
            for (int i = 0; i < count_threads; i++)
            {
                switch (i)
                {
                    case 0:
                        //Запускаем все потоки
                        for (int j = 0; j < count_threads; j++)
                        {
                            var thread = new Thread(new ParameterizedThreadStart(MultiThread1));
                            thread.IsBackground = true;
                            thread.Name = j.ToString();
                            _threads.Add(thread);
                            _threads[j].Start(thread.Name);
                        }
                        _threads.Clear();
                            break;
                        
                    case 1:
                        for (int k = 0; k < count_threads; k++)
                        {
                            var thread1 = new Thread(new ParameterizedThreadStart(MultiThread2));
                            thread1.IsBackground = true;
                            thread1.Name = k.ToString();
                            _threads.Add(thread1);
                            _threads[k].Start(thread1.Name);
                        }
                        _threads.Clear();
                        break;
                    case 2:
                        for (int h = 0; h < count_threads; h++)
                        {
                            var thread2 = new Thread(new ParameterizedThreadStart(MultiThread3));
                            thread2.IsBackground = true;
                            thread2.Name = h.ToString();
                            _threads.Add(thread2);
                            _threads[h].Start(thread2.Name);
                        }
                        _threads.Clear();
                        break;
                }
            }
        }
        
        Client client = new Client();
        public void MultiThread1(object Name)
        {
            int currrent_name = Convert.ToInt32(Name)+1;
            Thread.Sleep(500);
            //Палучил код документа, получил ссыль
            _ui(client.Code_success(currrent_name, true));
            Thread.Sleep(500);
        }
        public void MultiThread2(object Name)
        {
            int currrent_name = Convert.ToInt32(Name) + 1;
            //праверил ссылку
            Thread.Sleep(1000);
            _ui(client.URL_success(currrent_name, true));
            
        }
        public void MultiThread3(object Name)
        {
            int currrent_name = Convert.ToInt32(Name) + 1;
            //Сахранил крч!
            Thread.Sleep(1000);
            _ui(client.URL_saved(currrent_name,true));
            
            Thread.CurrentThread.Interrupt();
        }
        

        public void Abort()
        {
            foreach (Thread thread in _threads)
            {
                thread.Abort();
            }
            _threads.Clear();
        }
    }
    public class Client
    {
        public string Code_success(int Name, bool success)
        {
            string approve = "";
            if (success == true)
            {
                approve = "Ссылка №" + Name + " получена";
            }

            return approve;
        }
        public string URL_success(int Name, bool success)
        {
            string approve = "";
            if (success == true)
            {
                approve = "Ссылка №" + Name + " проверена!";
            }

            return approve;
        }
        public string URL_saved(int Name, bool success)
        {
            string approve = "";
            if (success == true)
            {
                approve = "Ссылка №" + Name + " сохранена!";
            }
            return approve;
        }
    }
}
