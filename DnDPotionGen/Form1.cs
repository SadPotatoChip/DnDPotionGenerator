using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDPotionGen
{
  public partial class Form1 : Form
  {
    private int Seed = 0;
    private Random r;
    
    public Form1()
    {
      InitializeComponent();
      
    }

    private void GenerateButton_Click(object sender, EventArgs e) {
      
      if (false == Int32.TryParse(SeedText.Text, out Seed)) {
        Seed = (int)DateTime.Now.Ticks;
      }
      r=new Random(Seed);

      var potion = new Potion();
      potion.Appearance = GetRandomFromList(PotionStats.Appearance);
      potion.Appearance2 = GetRandomFromList(PotionStats.Appearance);
      potion.Container = GetRandomFromList(PotionStats.Container);
      potion.Label = GetRandomFromList(PotionStats.Label);
      potion.Strength = GetRandomFromList(PotionStats.Strength);
      potion.Taste = GetRandomFromList(PotionStats.TasteSmell);
      potion.Texture = GetRandomFromList(PotionStats.Texture);
      potion.Title = GetRandomFromList(PotionStats.Title);
      potion.SideEffects = GetRandomFromList(PotionStats.SideEffects);
      var effect=GetRandomFromList(PotionStats.Effect);
      potion.Effect = effect.Item1;
      potion.Description = effect.Item2;
      OutputBox.Text = potion.ToString();

    }

    private T GetRandomFromList<T>(List<T> items) {
      var index = r.Next();
      index = index % items.Count;
      return items[index];
    }
  }
}
