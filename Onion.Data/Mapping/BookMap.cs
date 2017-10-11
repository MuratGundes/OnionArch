﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Data.Entities;

namespace Onion.Data.Mapping
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<Book> entityBuilder)  
        {  
            entityBuilder.HasKey(b => b.Id);
            entityBuilder.HasMany(b => b.BookSeries)
                .WithOne(bs => bs.Book)
                .HasForeignKey(bs => bs.BookId);
        } 
    }
}