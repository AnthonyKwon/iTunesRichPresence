using iTunesLib;

namespace iTunesRichPresence_Clone.Tokens {
    public class AlbumToken : IToken {
        public string DisplayName => "앨범";
        public string Token => "%album";
        public bool ShowInToolbox => true;
        public string GetText(IiTunes iTunes) {
            return iTunes.CurrentTrack.Album;
        }
    }
}