namespace DnDPotionGen {
    public class Potion {
        public string Title;
        public string Effect;
        public string Description;
        public string Strength;
        public string SideEffects;
        public string Container;
        public string Appearance;
        public string Appearance2;
        public string Texture;
        public string Taste;
        public string Label;

        public override string ToString() {
            var s = "";
            s += Title + " of " + Effect + "\n\n";
            s += Description + "\n\n";
            s += "Potency: " + Strength+ "\n"; 
            s += "Side Effects: " + SideEffects + "\n"; 
            s += "Container: " + Container + "\n"; 
            s += "Appearance : " + Appearance + " " + Appearance2 + "\n"; 
            s += "Texture: " + Texture + "\n"; 
            s += "Taste: " + Taste + "\n"; 
            s += "Label: " + Label + "\n";
            
            return s;
        }
    }
}