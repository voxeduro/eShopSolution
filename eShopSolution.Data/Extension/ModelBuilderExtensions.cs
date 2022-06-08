using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is homepage" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    SortOrder = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Enum.Status.Active
                },
                new Category()
                {
                    Id = 2,
                    SortOrder = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Enum.Status.Active,
                }
             );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new List<CategoryTranslation>()
                {
                    new CategoryTranslation() { Id = 1, CategoryId = 1, LanguageId = "vi-VN", Name = "Áo nam", SeoAlias = "ao-nam", SeoDescription = "Áo thời trang nam", SeoTitle = "Áo thời trang nam"},
                    new CategoryTranslation() { Id = 2, CategoryId = 1, LanguageId = "en-US", Name = "Men 's shirt", SeoAlias = "men-shirt", SeoDescription = "Men 's fashion shirt", SeoTitle = "Men 's fashion shirt"},
                    new CategoryTranslation() { Id = 3, CategoryId = 2, LanguageId = "vi-VN", Name = "Áo nữ", SeoAlias = "ao-nu", SeoDescription = "Áo thời trang nữ", SeoTitle = "Áo thời trang nữ"},
                    new CategoryTranslation() { Id = 4, CategoryId = 2, LanguageId = "en-US", Name = "Women 's shirt", SeoAlias = "women-shirt", SeoDescription = "Women 's fashion shirt", SeoTitle = "Women 's fashion shirt"}
                }
             );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    Price = 100000,
                    OriginalPrice = 50000,
                    ViewCount = 0,
                    Stock = 0
                }
             );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new List<ProductTranslation>()
                    {
                        new ProductTranslation()
                        {
                            Id = 1,
                            ProductId = 1,
                            LanguageId = "vi-VN",
                            Name = "Áo thun nam VT",
                            SeoAlias = "ao-thun-nam-vt",
                            SeoDescription = "Áo thun nam Việt Tiến",
                            SeoTitle = "Áo thun nam VT",
                            Details = "Áo thun nam Việt Tiến",
                            Description = "Áo thun nam Việt Tiến"
                        },
                        new ProductTranslation()
                        {
                            Id = 2,
                            ProductId = 1,
                            LanguageId = "en-US",
                            Name = "VT Men 's Tshirt",
                            SeoAlias = "vt-men-tshirt",
                            SeoDescription = "Viet Tien Men 's fashion Tshirt",
                            SeoTitle = "VT Men 's Tshirt",
                            Details = "Viet Tien Men 's fashion Tshirt",
                            Description = "Viet Tien Men 's fashion Tshirt"
                        }
                    }
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    CategoryId = 1, ProductId = 1
                }
            );
        }

        public static void Seed1(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is homepage" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    SortOrder = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Enum.Status.Active
                },
                new Category()
                {
                    Id = 2,
                    SortOrder = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Enum.Status.Active,
                }
             );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new List<CategoryTranslation>()
                {
                    new CategoryTranslation() { Id = 1, CategoryId = 1, LanguageId = "vi-VN", Name = "Áo nam", SeoAlias = "ao-nam", SeoDescription = "Áo thời trang nam", SeoTitle = "Áo thời trang nam"},
                    new CategoryTranslation() { Id = 2, CategoryId = 1, LanguageId = "en-US", Name = "Men 's shirt", SeoAlias = "men-shirt", SeoDescription = "Men 's fashion shirt", SeoTitle = "Men 's fashion shirt"},
                    new CategoryTranslation() { Id = 3, CategoryId = 2, LanguageId = "vi-VN", Name = "Áo nữ", SeoAlias = "ao-nu", SeoDescription = "Áo thời trang nữ", SeoTitle = "Áo thời trang nữ"},
                    new CategoryTranslation() { Id = 4, CategoryId = 2, LanguageId = "en-US", Name = "Women 's shirt", SeoAlias = "women-shirt", SeoDescription = "Women 's fashion shirt", SeoTitle = "Women 's fashion shirt"}
                }
             );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    Price = 100000,
                    OriginalPrice = 50000,
                    ViewCount = 0,
                    Stock = 0
                }
             );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new List<ProductTranslation>()
                    {
                        new ProductTranslation()
                        {
                            Id = 1,
                            ProductId = 1,
                            LanguageId = "vi-VN",
                            Name = "Áo thun nam VT",
                            SeoAlias = "ao-thun-nam-vt",
                            SeoDescription = "Áo thun nam Việt Tiến",
                            SeoTitle = "Áo thun nam VT",
                            Details = "Áo thun nam Việt Tiến",
                            Description = "Áo thun nam Việt Tiến"
                        },
                        new ProductTranslation()
                        {
                            Id = 2,
                            ProductId = 1,
                            LanguageId = "en-US",
                            Name = "VT Men 's Tshirt",
                            SeoAlias = "vt-men-tshirt",
                            SeoDescription = "Viet Tien Men 's fashion Tshirt",
                            SeoTitle = "VT Men 's Tshirt",
                            Details = "Viet Tien Men 's fashion Tshirt",
                            Description = "Viet Tien Men 's fashion Tshirt"
                        }
                    }
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    CategoryId = 1,
                    ProductId = 1
                }
            );
        }
    }
}
