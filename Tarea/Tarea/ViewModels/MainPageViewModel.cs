using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Tarea.Models;

namespace Tarea.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Song> Songs {get; set;}
        public MainPageViewModel()
        {
            Songs = new ObservableCollection<Song>
            {
                new Song
                {
                    Name="Heavydirtysoul",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra="There's an infestation in my mind's imagination" +
                    " I hope that they choke on smoke 'cause I'm smokin' them out the basement" +
                    "  This is not rap, this is not hip-hop" +
                    "Just another attempt to make the voices stop" +
                    " Rappin' to prove nothing, just writin' to say somethin'" +
                    "'Cause I wasn't the only one who wasn't rushin' to sayin' nothin'" +
                    "This doesn't mean I lost my dream" +
                    "     It's just right now I got a really crazy mind to clean"
                },
                new Song
                 {
                    Name="Stressed Out",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                },

                new Song
                 {
                    Name="Ride",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png"
                },

                new Song
                 {
                    Name="Fairly Local",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                },

                 new Song
                 {
                    Name="Tear in My Heart",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                },

                 new Song
                 {
                    Name="Lane Boy",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                 },

                 new Song
                 {
                    Name="The Judge",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                },

                  new Song
                 {
                    Name="The Judge",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                },

                   new Song
                 {
                    Name="Doubt",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                },

                    new Song
                    {
                    Name="Polarize",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                    },

                     new Song
                    {
                    Name="Message Man",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                    },

                    new Song
                    {
                    Name="No Today",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                    },

                    new Song
                    {
                    Name="Goner",
                    Album="Blurryface",
                    Image="https://e.snmc.io/i/600/s/36f848a4284922d4f2d8312ed88dde92/9764448/twenty-one-pilots-blurryface-Cover-Art.png",
                    Letra=""
                    },


            };
             
        }
    }
}
