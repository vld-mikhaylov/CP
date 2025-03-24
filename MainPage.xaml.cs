using Microsoft.Maui.Controls;
using Lab_1.ViewModels;

namespace Lab_1
{
    [QueryProperty(nameof(NoteId), "noteId")]
    public partial class MainPage : ContentPage
    {
        private NoteViewModel _viewModel;

        public int NoteId { get; set; }

        public MainPage()
        {
            InitializeComponent();
            _viewModel = (NoteViewModel)BindingContext;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _viewModel.LoadNoteAsync(NoteId);
        }
    }
}
