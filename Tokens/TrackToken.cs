using iTunesLib;

namespace iTunesRichPresence_Clone.Tokens {
    public class TrackToken : IToken {
        public string DisplayName => "트랙 이름";
        public string Token => "%track";
        public bool ShowInToolbox => true;
        public string GetText(IiTunes iTunes) {
            return iTunes.CurrentTrack.Name;
        }
    }
}