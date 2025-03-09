using System;


namespace tpmodul4_103022300116
{
    public class DoorMachine
    {
        private enum State { Terkunci, Terbuka}
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void Unlock()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah tidak terkunci");
            }
        }

        public void Lock()
        {
            if (currentState == State.Terbuka) { 
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci");
            }
        }
    }
}
