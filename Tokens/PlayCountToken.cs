using iTunesLib;

namespace iTunesRichPresence_Clone.Tokens
{
    class PlayCountToken : IToken {
        public string DisplayName => "재생 횟수";
        public string Token => "%play_count";
        public bool ShowInToolbox => true;
        public string GetText(IiTunes iTunes) {
            return iTunes.CurrentTrack.PlayedCount.ToString();
        }
    }
}
