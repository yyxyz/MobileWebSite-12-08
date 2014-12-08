using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class Directional_Release
    {
        [Key]
        [Required]
        [DisplayName("���򷢲�����")]
        public int Directional_Release_ID { get; set; }


        [Required]
        [DisplayName("��������ҵID")]
        public int Enterprise_ID { get; set; }
        [Required]
        [DisplayName("����ID")]
        public int Demand_ID { get; set; }

        public Enterprise Enterprise { get; set; }//��������
        public Demand Demand { get; set; }//��������


    }
}
