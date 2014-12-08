using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class Equipment
    {
        [Key]
        [DisplayName("�豸����")]
        public int Equipment_ID { get; set; }

        [Required]
        [DisplayName("��ҵID")]
        public int Enterprise_ID { get; set; }

        [Required]
        [DisplayName("�豸����")]
        public string Equipment_Name { get; set; }
        [DisplayName("�豸ͼƬ")]
        public byte[] Equipment_Picture { get; set; }
        [DisplayName("�豸����")]
        public string Equipment_Description { get; set;}

       [DisplayName("�豸����ʱ��")]
       public string Equipment_FreeBegin_Time { get; set;}
       public string Equipment_FreeEnd_Time { get; set; }

        public Enterprise Enterprise { get; set; }//��������

    }
}
