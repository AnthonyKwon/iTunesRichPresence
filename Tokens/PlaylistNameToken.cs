using iTunesLib;

namespace iTunesRichPresence_Clone.Tokens {
    public class PlaylistNameToken : IToken {
        public string DisplayName => "플레이리스트 이름";
        public string Token => "%playlist_name";
        public bool ShowInToolbox => true;
        public string GetText(IiTunes iTunes) {
            return iTunes.CurrentPlaylist.Name;
        }
    }
}