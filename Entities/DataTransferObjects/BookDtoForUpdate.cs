using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    //Bu şekilde tek tek oluşturulabilir, biz daha kısa olacak şekilde implemente ettik.
    //public record BookDtoForUpdate
    //{
    //    public int Id { get; init; } // set yerine init yazarak, readonly yapıyoruz. Set olmamalı, çünkü readonly olmaz!
    //    public String Title { get; init; }
    //    public decimal Price { get; init; }
    //}
    public record BookDtoForUpdate : BookDtoForManipulation
    {
        [Required]
        public int Id { get; set; }
    }
}