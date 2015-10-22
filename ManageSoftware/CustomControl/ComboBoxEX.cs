using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSoftware.CustomControl
{
    class ComboBoxEX : System.Windows.Forms.ComboBox
    {
        private List<CustomControl.Item> items;
        public ComboBoxEX() 
        {
            this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemHeight = 17;
            this.Size = new System.Drawing.Size(100, 23);
            this.DrawItem += ComboBoxEX_DrawItem;
            this.ValueMember = "Value";
            this.DisplayMember = "Name";
        }
        public ComboBoxEX(List<CustomControl.Item> _items) 
        {            
            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Image != null)
                    _items[i].Image = new Bitmap(_items[i].Image, new Size(12, 12));
            }
            items = _items;

            this.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemHeight = 17;
            this.Size = new System.Drawing.Size(100, 23);
            this.DrawItem += ComboBoxEX_DrawItem;
            this.DataSource = items;
            this.ValueMember = "Value";
            this.DisplayMember = "Name";
        }

        public void ComboBoxEX_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            Font f = this.Font;
            int yOffset = 0;

            if ((e.State & System.Windows.Forms.DrawItemState.Focus) == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                if ((this.Items[e.Index]).Image != null)
                {
                    e.Graphics.DrawString(((CustomControl.Item)this.Items[e.Index]).Value.ToString(), f, Brushes.Black, new Point(((CustomControl.Item)this.Items[e.Index]).Image.Width * 2, e.Bounds.Y + yOffset));
                    e.Graphics.DrawImage(((CustomControl.Item)this.Items[e.Index]).Image, new Point(e.Bounds.X, e.Bounds.Y + yOffset));
                } 
                else
                {
                    e.Graphics.DrawString(((CustomControl.Item)this.Items[e.Index]).Value.ToString(), f, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y + yOffset));
                }
                
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Wheat, e.Bounds);
                if ((this.Items[e.Index]).Image != null)
                {
                    e.Graphics.DrawString(((CustomControl.Item)this.Items[e.Index]).Value.ToString(), f, Brushes.Black, new Point(((CustomControl.Item)this.Items[e.Index]).Image.Width * 2, e.Bounds.Y + yOffset));
                    e.Graphics.DrawImage(((CustomControl.Item)this.Items[e.Index]).Image, new Point(e.Bounds.X, e.Bounds.Y + yOffset));
                }
                else
                {
                    e.Graphics.DrawString(((CustomControl.Item)this.Items[e.Index]).Value.ToString(), f, Brushes.Black, new Point(e.Bounds.X, e.Bounds.Y + yOffset));
                }
            }
        }

        public new List<CustomControl.Item> Items
        {
            set 
            { 
                this.DataSource = value;
            }
            get
            {
                return (List<CustomControl.Item>)this.DataSource;
            }
        }

        public void SizeImage(Size _size)
        {
            for (int i = 0; i < items.Count; i++)
            {
                items[i].Image = new Bitmap(items[i].Image, _size);
            }
        }
    }

    class Item
    {
        public Item() { }
        public Item(String name, String value, Image image) 
        {
            this.Name = name;
            this.Value = value;
            this.Image = image;
        }
        public String Name { set; get;}
        public String Value { set; get; }
        public Image Image { set; get; }
    }
}
