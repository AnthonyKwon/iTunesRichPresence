using iTunesLib;

namespace iTunesRichPresence_Clone.Tokens.Hidden {
    public class PushesToken : IToken {
        public string DisplayName => "Pushes";
        public string Token => "%pushes";
        public bool ShowInToolbox => false;
        private int _pushes = 0;
        public string GetText(IiTunes iTunes) {
            _pushes++;
            return _pushes.ToString();
        }
    }
}