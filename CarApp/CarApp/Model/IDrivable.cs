namespace CarApp.Model
{
    interface IDrivable
    {
        public void StartEngine();
        public void StopEngine();
        public void Drive(double distance);
        public bool CanDrive(double distance);
    }
}
