using Microsoft.Maui.Controls;
using Lab_1.Models;

namespace Lab_1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("viewpage", typeof(ViewPage)); // Ensure MainPage is the correct page type
            Routing.RegisterRoute("allnotes", typeof(AllNotes)); // Register AllNotes route
        }
    }
}