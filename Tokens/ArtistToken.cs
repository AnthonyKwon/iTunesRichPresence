using iTunesLib;

namespace iTunesRichPresence_Clone.Tokens {
    public class ArtistToken : IToken {
        public string DisplayName => "아티스트";
        public string Token => "%artist";
        public bool ShowInToolbox => true;
        public string GetText(IiTunes iTunes) {
            return iTunes.CurrentTrack.Artist;
        }
    }
}