using System;
using System.Collections.Generic;

namespace Homework1
{
    class DummyDatabase
    {
        private bool IsConnected = false;
        public List<string> WordsSaved = new List<string>();
        public class DummyDatabaseConnectionException : Exception
        {
            public DummyDatabaseConnectionException(string message) : base(message)
            {

            }
        }
        public void Connect()
        {
            Random r = new Random();
            int rand = r.Next(1, 6);
            try
            {
                if (rand == 1)
                {

                    IsConnected = false;
                    throw new DummyDatabaseConnectionException("DummyDatabaseConnectionException. " + " Failed trying to connect. Try again");
                }
                IsConnected = true;
                Console.WriteLine("Connection established");

            }
            catch (DummyDatabaseConnectionException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finish trying to connect");
            }


        }

        public void Disconnect()
        {
            IsConnected = false;
            Console.WriteLine("You have been disconnected.");
        }
        public void Save(string wordToSave)
        {
            if (IsConnected == true)
            {
                if (WordsSaved.Count < 5)
                    WordsSaved.Add(wordToSave);
                else
                {
                    Console.WriteLine("The DummyDatabase is full.");
                }
            }
            else
            {
                Console.WriteLine("It's not connected");
            }
        }
    }
}
