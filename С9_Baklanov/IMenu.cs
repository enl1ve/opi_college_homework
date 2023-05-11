namespace C9_Baklanov
{
    internal interface IMenu
    {
        bool Flag { get; set; }
        void CleanUp();
        void Idle();
        void Init();
    }
}