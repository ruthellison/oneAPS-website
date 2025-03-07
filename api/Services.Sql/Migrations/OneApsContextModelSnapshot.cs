﻿// <auto-generated />
using System;
using Dta.OneAps.Api.Services.Sql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Dta.OneAps.Api.Services.Sql.Migrations
{
    [DbContext(typeof(OneApsContext))]
    partial class OneApsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("Relational:Sequence:.key_value_id_seq", "'key_value_id_seq', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.opportunity_assessor_id_seq", "'opportunity_assessor_id_seq', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.opportunity_history_id_seq", "'opportunity_history_id_seq', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.opportunity_question_id_seq", "'opportunity_question_id_seq', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.opportunity_response_answer_id_seq", "'opportunity_response_answer_id_seq', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.opportunity_response_contact_id_seq", "'opportunity_response_contact_id_seq', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.opportunity_response_download_id_seq", "'opportunity_response_download_id_seq', '', '1', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.user_claim_id_seq", "'user_claim_id_seq', '', '1', '1', '', '', 'Int64', 'False'");

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.KeyValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Data")
                        .HasColumnName("data")
                        .HasColumnType("json");

                    b.Property<string>("Key")
                        .HasColumnName("key")
                        .HasColumnType("character varying");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique()
                        .HasName("key_value_key_key");

                    b.HasIndex("UpdatedAt")
                        .HasName("ix_key_value_updated_at");

                    b.ToTable("key_value");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.Opportunity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AboutTeam")
                        .HasColumnName("about_team")
                        .HasColumnType("text");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnName("additional_info")
                        .HasColumnType("text");

                    b.Property<string>("Agency")
                        .HasColumnName("agency")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ClosedAt")
                        .HasColumnName("closed_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CommitmentTime")
                        .HasColumnName("commitment_time")
                        .HasColumnType("text");

                    b.Property<string>("ContactPersonEmail")
                        .HasColumnName("contact_person_email")
                        .HasColumnType("text");

                    b.Property<string>("ContactPersonName")
                        .HasColumnName("contact_person_name")
                        .HasColumnType("text");

                    b.Property<string>("ContactPersonPhone")
                        .HasColumnName("contact_person_phone")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CreatedBy")
                        .HasColumnName("created_by")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndDate")
                        .HasColumnName("end_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("JobDescription")
                        .HasColumnName("job_description")
                        .HasColumnType("text");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnName("job_title")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnName("location")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Modifed")
                        .HasColumnName("modifed")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("ModifiedBy")
                        .HasColumnName("modified_by")
                        .HasColumnType("integer");

                    b.Property<string>("NumberOfPeople")
                        .HasColumnName("number_of_people")
                        .HasColumnType("text");

                    b.Property<DateTime?>("PublishedAt")
                        .HasColumnName("published_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SecurityClearance")
                        .HasColumnName("security_clearance ")
                        .HasColumnType("text");

                    b.Property<string>("Skills")
                        .HasColumnName("skills")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnName("start_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("WhatYoullGain")
                        .HasColumnName("what_you_gain")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("EndDate")
                        .HasName("ix_opportunity_end_date");

                    b.HasIndex("JobTitle")
                        .HasName("ix_opportunity_job_title");

                    b.HasIndex("ModifiedBy");

                    b.HasIndex("StartDate")
                        .HasName("ix_opportunity_start_date");

                    b.ToTable("opportunity");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityAssessor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EmailAddress")
                        .HasColumnName("email_address")
                        .HasColumnType("character varying");

                    b.Property<int>("OpportunityId")
                        .HasColumnName("opportunity_id")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OpportunityId");

                    b.HasIndex("UserId");

                    b.ToTable("opportunity_assessor");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityClarificationQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnName("answer")
                        .HasColumnType("character varying");

                    b.Property<int>("OpportunityId")
                        .HasColumnName("opportunity_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnName("published_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnName("question")
                        .HasColumnType("character varying");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OpportunityId");

                    b.HasIndex("PublishedAt")
                        .HasName("ix_opportunity_clarification_question_published_at");

                    b.HasIndex("UserId");

                    b.ToTable("opportunity_clarification_question");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnName("data")
                        .HasColumnType("json");

                    b.Property<DateTime>("EditedAt")
                        .HasColumnName("edited_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OpportunityId")
                        .HasColumnName("opportunity_id")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EditedAt")
                        .HasName("ix_opportunity_history_edited_at");

                    b.HasIndex("OpportunityId")
                        .HasName("ix_opportunity_history_opportunity_id");

                    b.HasIndex("UserId")
                        .HasName("ix_opportunity_history_user_id");

                    b.ToTable("opportunity_history");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Agency")
                        .HasColumnName("agency")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnName("data")
                        .HasColumnType("json");

                    b.Property<int>("OpportunityId")
                        .HasColumnName("opportunity_id")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("text");

                    b.Property<string>("ResumeLink")
                        .HasColumnName("resume_link")
                        .HasColumnType("text");

                    b.Property<string>("ResumeUpload")
                        .HasColumnName("resume_upload")
                        .HasColumnType("text");

                    b.Property<DateTime?>("SubmittedAt")
                        .HasColumnName("submitted_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.Property<string>("WhyPickMe")
                        .HasColumnName("why_pick_me")
                        .HasColumnType("text");

                    b.Property<DateTime?>("WithdrawnAt")
                        .HasColumnName("withdrawn_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt")
                        .HasName("ix_opportunity_response_created_at");

                    b.HasIndex("OpportunityId");

                    b.HasIndex("SubmittedAt")
                        .HasName("ix_opportunity_response_submitted_at");

                    b.HasIndex("UpdatedAt")
                        .HasName("ix_opportunity_response_updated_at");

                    b.HasIndex("UserId");

                    b.ToTable("opportunity_response");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityResponseContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnName("email_address")
                        .HasColumnType("character varying");

                    b.Property<int>("OpportunityId")
                        .HasColumnName("opportunity_id")
                        .HasColumnType("integer");

                    b.Property<long>("SupplierCode")
                        .HasColumnName("supplier_code")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OpportunityId");

                    b.ToTable("opportunity_response_contact");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityResponseDownload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OpportunityId")
                        .HasColumnName("opportunity_id")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CreatedAt")
                        .HasName("ix_opportunity_response_download_created_at");

                    b.HasIndex("OpportunityId");

                    b.HasIndex("UserId");

                    b.ToTable("opportunity_response_download");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunitySkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("OpportunityId")
                        .HasColumnName("opportunity_id")
                        .HasColumnType("integer");

                    b.Property<int>("SkillKey")
                        .HasColumnName("skill_key")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("opportunity_skill_pkey");

                    b.HasIndex("OpportunityId");

                    b.ToTable("opportunity_skill");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityUser", b =>
                {
                    b.Property<int>("OpportunityId")
                        .HasColumnName("opportunity_id")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("OpportunityId", "UserId")
                        .HasName("opportunity_user_pkey");

                    b.HasIndex("UserId");

                    b.ToTable("opportunity_user");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnName("active")
                        .HasColumnType("boolean");

                    b.Property<string>("Agency")
                        .HasColumnName("agency")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnName("email_address")
                        .HasColumnType("character varying");

                    b.Property<bool>("EmailVerified")
                        .HasColumnName("email_verified")
                        .HasColumnType("boolean");

                    b.Property<int>("FailedLoginCount")
                        .HasColumnName("failed_login_count")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LoggedInAt")
                        .HasColumnName("logged_in_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnName("mobile")
                        .HasColumnType("character varying");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("character varying");

                    b.Property<DateTime>("PasswordChangedAt")
                        .HasColumnName("password_changed_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Role")
                        .HasColumnName("role")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id")
                        .HasName("user_pkey");

                    b.HasIndex("EmailAddress")
                        .IsUnique()
                        .HasName("ix_user_email_address");

                    b.ToTable("user");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimToken")
                        .HasColumnName("claim_token")
                        .HasColumnType("text");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsClaimed")
                        .HasColumnName("is_claimed")
                        .HasColumnType("boolean");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("integer");

                    b.HasKey("Id")
                        .HasName("user_claim_pkey");

                    b.HasIndex("UserId");

                    b.ToTable("user_claim");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.Opportunity", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.User", "CreatedByUser")
                        .WithMany("OpportunityCreatedByUser")
                        .HasForeignKey("CreatedBy")
                        .HasConstraintName("opportunity_created_by_user_id_fkey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dta.OneAps.Api.Services.Entities.User", "ModifiedByUser")
                        .WithMany("OpportunityModifiedByUser")
                        .HasForeignKey("ModifiedBy")
                        .HasConstraintName("opportunity_modified_by_user_id_fkey");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityAssessor", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.Opportunity", "Opportunity")
                        .WithMany("OpportunityAssessor")
                        .HasForeignKey("OpportunityId")
                        .HasConstraintName("opportunity_assessor_opportunity_id_fkey")
                        .IsRequired();

                    b.HasOne("Dta.OneAps.Api.Services.Entities.User", "User")
                        .WithMany("OpportunityAssessor")
                        .HasForeignKey("UserId")
                        .HasConstraintName("opportunity_assessor_user_id_fkey");
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityClarificationQuestion", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.Opportunity", "Opportunity")
                        .WithMany("OpportunityClarificationQuestion")
                        .HasForeignKey("OpportunityId")
                        .HasConstraintName("opportunity_clarification_question_opportunity_id_fkey")
                        .IsRequired();

                    b.HasOne("Dta.OneAps.Api.Services.Entities.User", "User")
                        .WithMany("OpportunityClarificationQuestion")
                        .HasForeignKey("UserId")
                        .HasConstraintName("opportunity_clarification_question_user_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityHistory", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.Opportunity", "Opportunity")
                        .WithMany("OpportunityHistory")
                        .HasForeignKey("OpportunityId")
                        .HasConstraintName("opportunity_history_opportunity_id_fkey")
                        .IsRequired();

                    b.HasOne("Dta.OneAps.Api.Services.Entities.User", "User")
                        .WithMany("OpportunityHistory")
                        .HasForeignKey("UserId")
                        .HasConstraintName("opportunity_history_user_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityResponse", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.Opportunity", "Opportunity")
                        .WithMany("OpportunityResponse")
                        .HasForeignKey("OpportunityId")
                        .HasConstraintName("opportunity_response_opportunity_id_fkey")
                        .IsRequired();

                    b.HasOne("Dta.OneAps.Api.Services.Entities.User", "User")
                        .WithMany("OpportunityResponses")
                        .HasForeignKey("UserId")
                        .HasConstraintName("opportunity_response_user_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityResponseContact", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.Opportunity", "Opportunity")
                        .WithMany("OpportunityResponseContact")
                        .HasForeignKey("OpportunityId")
                        .HasConstraintName("opportunity_response_opportunity_contact_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityResponseDownload", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.Opportunity", "Opportunity")
                        .WithMany("OpportunityResponseDownload")
                        .HasForeignKey("OpportunityId")
                        .HasConstraintName("opportunity_response_download_opportunity_id_fkey")
                        .IsRequired();

                    b.HasOne("Dta.OneAps.Api.Services.Entities.User", "User")
                        .WithMany("OpportunityResponseDownload")
                        .HasForeignKey("UserId")
                        .HasConstraintName("opportunity_response_download_user_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunitySkill", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.Opportunity", "Opportunity")
                        .WithMany("OpportunitySkills")
                        .HasForeignKey("OpportunityId")
                        .HasConstraintName("opportunity_skill_opportunity_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.OpportunityUser", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.Opportunity", "Opportunity")
                        .WithMany("OpportunityUser")
                        .HasForeignKey("OpportunityId")
                        .HasConstraintName("opportunity_user_opportunity_id_fkey")
                        .IsRequired();

                    b.HasOne("Dta.OneAps.Api.Services.Entities.User", "User")
                        .WithMany("OpportunityUser")
                        .HasForeignKey("UserId")
                        .HasConstraintName("opportunity_user_user_id_fkey")
                        .IsRequired();
                });

            modelBuilder.Entity("Dta.OneAps.Api.Services.Entities.UserClaim", b =>
                {
                    b.HasOne("Dta.OneAps.Api.Services.Entities.User", "User")
                        .WithMany("UserClaims")
                        .HasForeignKey("UserId")
                        .HasConstraintName("user_claims_user_id_fkey")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
