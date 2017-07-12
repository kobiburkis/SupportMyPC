using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SupportMyPC.Models;

namespace SupportMyPC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170712183935_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SupportMyPC.Models.SupportCall", b =>
                {
                    b.Property<int>("SupportCallId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustEmail");

                    b.Property<string>("CustID");

                    b.Property<string>("CustName")
                        .IsRequired();

                    b.Property<string>("CustPhone")
                        .IsRequired();

                    b.Property<string>("ProblemDescription");

                    b.Property<string>("ProblemMachine");

                    b.Property<int>("ProblemMachineID");

                    b.Property<bool?>("RegisteredCust");

                    b.Property<string>("SupportCallDate");

                    b.Property<string>("SupportCallStatus");

                    b.Property<int>("SupportCallStatusID");

                    b.Property<DateTime>("SupportCallTreatDate");

                    b.HasKey("SupportCallId");

                    b.ToTable("supportCalls");
                });
        }
    }
}
