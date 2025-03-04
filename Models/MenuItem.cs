namespace BlazorMenuApp.Models
{
    public class MenuItem
    {
        public string Text { get; set; } = string.Empty;
        public List<MenuItem> Children { get; set; } = new();
        public bool IsOpen { get; set; } = false;
    }
}