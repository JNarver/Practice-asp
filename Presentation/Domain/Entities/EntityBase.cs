using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Domain.Entities
{
    public abstract class EntityBase
    {
        //this class won't participate in our object(domain) model
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get; set; }
        [Display(Name = "Name(Заголовок)")]
        public virtual string Title { get; set; }
        [Display(Name = "Short description")]
        public virtual string Subtitle {get; set;}
        [Display(Name = "Description")]
        public virtual string Text { get; set; }
        [Display(Name = "Title screen")]
        public virtual string TitleImagePath { get; set; }
        [Display(Name = "Ceo metatag title")]
        public string MetaTitle { get; set; }
        [Display(Name = "Ceo metatag description")]
        public string MetaDescription { get; set; }
        [Display(Name = "Ceo metatag keywords")]
        public string MetaKeywords { get; set; }
        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
        
    }
}
