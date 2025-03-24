using Microsoft.Maui.Controls;
using Lab_1.Models;

namespace Lab_1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("mainpage", typeof(MainPage)); // Ensure MainPage is the correct page type
        }

        private async void OnNoteSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Note selectedNote)
            {
                await Shell.Current.GoToAsync($"mainpage?noteId={selectedNote.Id}");
            }
        }
    }

}
