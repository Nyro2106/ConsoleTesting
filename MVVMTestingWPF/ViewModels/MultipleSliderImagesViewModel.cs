using MVVMTestingWPF.Helpers;
using MVVMTestingWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTestingWPF.ViewModels
{
  class MultipleSliderImagesViewModel : PropertyChangedEntity
  {
    SliderImage[] SliderImages = new SliderImage[]
    {
      new SliderImage() { ImagePath = @"D:\Visual Studio 2017\Projects\Schrodinger\ConsoleTesting\MVVMTestingWPF\Assets\Cup.jpg", Name = "Großer Brauner" },
      new SliderImage() { ImagePath = @"D:\Visual Studio 2017\Projects\Schrodinger\ConsoleTesting\MVVMTestingWPF\Assets\espresso.png", Name = "Kleines Schwarzes" },
      new SliderImage() { ImagePath = @"D:\Visual Studio 2017\Projects\Schrodinger\ConsoleTesting\MVVMTestingWPF\Assets\kaffee.png", Name = "Verlängerter" },
    };

    public SliderImage CurrentSliderImage
    {
      get
      {
        if (this.index >= 0 && this.index <= SliderImages.Length)
        {
          return SliderImages[this.index];
        }
        return SliderImages[0];
      }
    }

    private int index;

    public int Index
    {
      get { return this.index; }
      set
      {
        this.index = value;
        this.OnPropertyChanged();
        this.OnPropertyChanged(nameof(CurrentSliderImage));
      }
    }

  }
}
