using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMAUIMobileApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.Models.Messages
{
    public class UpdateMovieMessage : ValueChangedMessage<(MarvelMovies OldValue, MarvelMovies NewValue)>
    {
        public UpdateMovieMessage(MarvelMovies oldValue, MarvelMovies newValue)
            : base((oldValue, newValue)) { }

        public MarvelMovies OldValue => Value.OldValue;
        public MarvelMovies NewValue => Value.NewValue;
    }
}
