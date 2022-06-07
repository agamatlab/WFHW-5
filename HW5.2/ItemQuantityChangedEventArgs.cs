namespace HW5._2
{
    public delegate void ItemQuantityChangedEventHandler(object sender, ItemQuantityChangedEventArgs e);

    public class ItemQuantityChangedEventArgs : EventArgs
    {
        public ItemQuantityChangedEventArgs(bool increment)
        {
            Increment = increment;
        }

        public bool Increment { get; }



    }
}
