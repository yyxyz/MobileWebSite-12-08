
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CPCApp.Data.Model
{
    public partial class Class
    {
        [Key]
        [DisplayName("��ҵ�������������")]
        public int Class_ID { get; set; }


        
        [DisplayName("�ϼ��������")]
        public Nullable <int> PIDClass_ID { get; set; }

        [Required]
        [DisplayName("�������")]
        public string Class_Name { get; set; }

        [DisplayName("�������")]
        public string Class_Description { get; set; }


        //��������
        public Class PID { get; set; }
        public ICollection<EnterpriseClass> EnterpriseClass { get; set; }
        public ICollection<DemandClass> DemandClass { get; set; }

       
    }
}
