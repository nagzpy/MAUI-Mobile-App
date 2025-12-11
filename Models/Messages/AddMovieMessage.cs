using CommunityToolkit.Mvvm.Messaging.Messages;
using MyFirstMAUIMobileApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMAUIMobileApp.Models.Messages
{
    public class AddMovieMessage : ValueChangedMessage<MarvelMovies>
    {
        public AddMovieMessage(MarvelMovies value) : base(value) { }
    }
}
