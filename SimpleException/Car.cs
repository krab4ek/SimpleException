namespace SimpleException
{
    internal class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = string.Empty;

        private bool carIsDead;

        private Radio theMusicBox = new Radio();

        public Car()
        {

        }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine($"{PetName} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    carIsDead = true;
                    Exception ex = new Exception($"{PetName} has overheated!");
                    ex.HelpLink = "https://github.com/krab4ek" +
                        " ***** Bog v pomosh! ****** ";
                    ex.Data.Add("TimeStamp",$"The car exploaded at {DateTime.Now}");
                    ex.Data.Add("Cause","You have a lead foot!");
                    throw ex;
                    //throw new Exception($"{PetName} has overheated!");
                }
                else
                {
                    Console.WriteLine($"=> Curren Speed = {CurrentSpeed}");
                }
            }
        }
    }
}
