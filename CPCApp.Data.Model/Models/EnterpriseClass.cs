using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class EnterpriseClass
    {
        [Key]
        [DisplayName("��ҵ��������")]
        public int EnterpriseClass_ID { get; set; }

        [Required]
        [DisplayName("��������")]
        public int Class_ID { get; set; }

        [Required]
        [DisplayName("��ҵ����")]
        public int Enterprise_ID { get; set; }


        //��������
        public Enterprise Enterprise { get; set; }
        public Class Class { get; set; }
    }
}
