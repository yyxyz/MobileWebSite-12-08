using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class Case
    {
        [Key]
        [DisplayName("��������")]
        public int Case_ID { get; set; }

        [Required]
        [DisplayName("��ҵ����")]
        public int Enterprise_ID { get; set; }

        [Required]
        [DisplayName("��������")]
        public string Case_Name { get; set; }

 
        [DisplayName("����ͼƬ")]
        public byte[] Case_Picture { get; set; }


        [DisplayName("��������")]
        public string Case_Description { get; set; }


        public Enterprise Enterprise { get; set; }//��������*/
    }
}
