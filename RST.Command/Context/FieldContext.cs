namespace RST.Command.Context
{

    /// <summary>
    /// Mocup class to mock "game" field. Uses static because of IoC container useing banned
    /// </summary>
    public static class FieldContext
    {
        public static int FieldWIdth { get; set; }
        public static int FieldHeight { get; set; }
    }
}
