using System;
using System.Collections.Generic;
using MLToolkit.Forms.SwipeCardView.Core;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using VideoCardDemo.Models;
using VideoCardDemo.ViewModels;
using Xamarin.Forms;

namespace SwipeCardView.Sample.ViewModel
{
    public class SimplePageViewModel : BasePageViewModel
    {
        private List<VideoData> _cardItems;
        private bool _isLoopCards;
        private string _message;
        private VideoData _topItem;

        public SimplePageViewModel()
        {
            _cardItems = new List<VideoData>();
            for (var i = 1; i <= 5; i++)
            {
                _cardItems.Add(new VideoData
                {
                    Id = i,
                    Source = ""
                });
            }
            _isLoopCards = true;
            SwipedCommand = new Command<SwipedCardEventArgs>(OnSwipedCommand);

            ClearItemsCommand = new Command(OnClearItemsCommand);
            AddItemsCommand = new Command(OnAddItemsCommand);
            PlayCommand = new Command(OnPlay);
            PauseCommand = new Command(OnPause);
            StopCommand = new Command(OnStop);
        }

        public VideoData TopItem
        {
            get => _topItem;
            set
            {
                _topItem = value;
                RaisePropertyChanged();
            }
        }

        private void OnStop()
        {
            
        }


        private void OnPause(object obj)
        {
            
        }

        private void OnPlay()
        {
            
        }

        public List<VideoData> CardItems
        {
            get => _cardItems;
            set
            {
                _cardItems = value;
                RaisePropertyChanged();
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                RaisePropertyChanged();
            }
        }

        public bool IsLoopCards
        {
            get => _isLoopCards;
            set
            {
                _isLoopCards = value;
                RaisePropertyChanged();
            }
        }

        public ICommand SwipedCommand { get; }

        public ICommand ClearItemsCommand { get; }

        public ICommand AddItemsCommand { get; }

        public ICommand PlayCommand { get; }

        public ICommand PauseCommand { get; }

        public ICommand StopCommand { get; }

        private void OnSwipedCommand(SwipedCardEventArgs eventArgs)
        {
            //var item = eventArgs.Item as string;
            //Message = $"{item} swiped {eventArgs.Direction}";
            if (TopItem != null)
            {
                //var curr = CardItems.FirstOrDefault(i => i.Id == TopItem.Id);
                //curr.Source = "";
                foreach (var item in CardItems)
                {
                    item.Source = "";
                }

                var tmp = new List<VideoData>();
                tmp = CardItems;
                CardItems = null;
                CardItems = tmp;
            }
        }

        private void OnClearItemsCommand()
        {
            //CardItems.Clear();
            //Message = string.Empty;
            if (TopItem != null)
            {
                var curr = CardItems.FirstOrDefault(i => i.Id == TopItem.Id);
                curr.Source = "";
            }
        }

        private void OnAddItemsCommand()
        {
            if (TopItem != null)
            {
                var curr = CardItems.FirstOrDefault(i => i.Id == TopItem.Id);
                curr.Source = "AndroidApiVideo.mp4";
                //"https://archive.org/download/BigBuckBunny_328/BigBuckBunny_512kb.mp4";
            }
        }
    }
}