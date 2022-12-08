namespace WindowsFormsApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KetQua")]
    public partial class KetQua
    {
        public float ketqua { get; set; }
    }
}
