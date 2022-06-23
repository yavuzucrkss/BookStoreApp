using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApp
{
    class ProductSeperator
    {
        public UserControl CreateUC_Product(Product _product)
        {
            if (_product is Book)
            {
                return new UCBook((Book)_product);
            }
            else if (_product is MusicCD)
            {
                return new UCMusic((MusicCD)_product);
            }
            else if (_product is Magazine)
            {
                return new UCMagazine((Magazine)_product);
            }
            else
                return null;
        }
    }
}
