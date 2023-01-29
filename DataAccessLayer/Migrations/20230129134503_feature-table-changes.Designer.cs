﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230129134503_feature-table-changes")]
    partial class featuretablechanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.About", b =>
                {
                    b.Property<int>("AboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutID"));

                    b.Property<string>("AboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDescription2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("AboutID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.About2", b =>
                {
                    b.Property<int>("About2ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("About2ID"));

                    b.Property<string>("About2Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("About2Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("About2Title1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("About2Title2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("About2ID");

                    b.ToTable("About2s");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactID"));

                    b.Property<string>("ContactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ContactStatus")
                        .HasColumnType("bit");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Destination", b =>
                {
                    b.Property<int>("DestinationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinationID"));

                    b.Property<int>("DestinationCapacity")
                        .HasColumnType("int");

                    b.Property<string>("DestinationCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationDayNight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DestinationPrice")
                        .HasColumnType("float");

                    b.Property<string>("DestinationStartingCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DestinationStatus")
                        .HasColumnType("bit");

                    b.HasKey("DestinationID");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Feature", b =>
                {
                    b.Property<int>("FeatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureID"));

                    b.Property<string>("FeatureDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FeatureLastTwo")
                        .HasColumnType("bit");

                    b.Property<bool>("FeatureStatus")
                        .HasColumnType("bit");

                    b.Property<string>("FeatureTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureID");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("EntityLayer.Concrete.FeatureOther", b =>
                {
                    b.Property<int>("FeatureOthersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeatureOthersID"));

                    b.Property<string>("FeatureOthersDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FeatureOthersImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FeatureOthersStatus")
                        .HasColumnType("bit");

                    b.Property<string>("FeatureOthersTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeatureOthersID");

                    b.ToTable("FeatureOthers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Guide", b =>
                {
                    b.Property<int>("GuideID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuideID"));

                    b.Property<string>("GuideDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuideImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuideInstagramURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuideName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GuideStatus")
                        .HasColumnType("bit");

                    b.Property<string>("GuideTwitterURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuideID");

                    b.ToTable("Guides");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Newsletter", b =>
                {
                    b.Property<int>("NewsletterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NewsletterID"));

                    b.Property<string>("NewsletterMail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NewsletterID");

                    b.ToTable("Newsletters");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SubAbout", b =>
                {
                    b.Property<int>("SubAboutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubAboutID"));

                    b.Property<string>("SubAboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubAboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubAboutID");

                    b.ToTable("SubAbouts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Testimonial", b =>
                {
                    b.Property<int>("TestimonialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestimonialID"));

                    b.Property<string>("TestimonialComment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestimonialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TestimonialStatus")
                        .HasColumnType("bit");

                    b.HasKey("TestimonialID");

                    b.ToTable("Testimonials");
                });
#pragma warning restore 612, 618
        }
    }
}
