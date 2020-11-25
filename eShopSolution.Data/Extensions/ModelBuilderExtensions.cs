﻿using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
              new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
              new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
              new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
              );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                 new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                    
                },
                  new Category()
                  {
                      Id = 2,
                      IsShowOnHome = true,
                      ParentId = null,
                      SortOrder = 2,
                      Status = Status.Active
                    
                  }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                 new CategoryTranslation() {Id = 1, CategoryId = 1, Name = "Điện thoại", LanguageId = "vi-VN", SeoAlias = "dien-thoai", SeoDescription = "Sản phẩm điện thoại", SeoTitle = "Sản phẩm điện thoại" },
                 new CategoryTranslation() {Id = 2, CategoryId = 1, Name = "Telephone", LanguageId = "en-US", SeoAlias = "telephone", SeoDescription = "The telephone products", SeoTitle = "The telephone products" },
                 new CategoryTranslation() {Id = 3,CategoryId = 2, Name = "Máy tính", LanguageId = "vi-VN", SeoAlias = "may-tinh", SeoDescription = "Sản phẩm máy tính", SeoTitle = "Sản phẩm máy tính" },
                 new CategoryTranslation() {Id = 4, CategoryId = 2, Name = "Laptop", LanguageId = "en-US", SeoAlias = "laptop", SeoDescription = "The laptop products", SeoTitle = "The laptop products" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id  = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 1000000,
                    Price = 2000000,
                    Stock = 0,
                    ViewCount = 0
               
                   

                }
                );
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation() {Id = 1, ProductId = 1, Name = "Điện thoại Samsung", LanguageId = "vi-VN", SeoAlias = "dien-thoai", SeoDescription = "Điện thoại Samsung", SeoTitle = "Điện thoại Samsung", Details = "Điện thoại Samsung", Description = "Điện thoại Samsung" },
                new ProductTranslation() {Id = 2, ProductId = 1, Name = "Telephone Samsung", LanguageId = "en-US", SeoAlias = "dien-thoai", SeoDescription = "Telephone Samsung", SeoTitle = "Telephone Samsung", Details = "Telephone Samsung", Description = "Telephone Samsung" }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1}
                );

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tedu.international@gmail.com",
                NormalizedEmail = "tedu.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Toan",
                LastName = "Bach",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}