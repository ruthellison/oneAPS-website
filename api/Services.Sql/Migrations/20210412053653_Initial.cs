﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Dta.OneAps.Api.Services.Sql.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "key_value_id_seq");

            migrationBuilder.CreateSequence(
                name: "opportunity_assessor_id_seq");

            migrationBuilder.CreateSequence(
                name: "opportunity_history_id_seq");

            migrationBuilder.CreateSequence(
                name: "opportunity_question_id_seq");

            migrationBuilder.CreateSequence(
                name: "opportunity_response_answer_id_seq");

            migrationBuilder.CreateSequence(
                name: "opportunity_response_contact_id_seq");

            migrationBuilder.CreateSequence(
                name: "opportunity_response_download_id_seq");

            migrationBuilder.CreateTable(
                name: "key_value",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    updated_at = table.Column<DateTime>(nullable: false),
                    key = table.Column<string>(type: "character varying", nullable: true),
                    data = table.Column<string>(type: "json", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_key_value", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying", nullable: false),
                    email_address = table.Column<string>(type: "character varying", nullable: false),
                    password = table.Column<string>(type: "character varying", nullable: false),
                    active = table.Column<bool>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    password_changed_at = table.Column<DateTime>(nullable: false),
                    logged_in_at = table.Column<DateTime>(nullable: true),
                    failed_login_count = table.Column<int>(nullable: false),
                    agency = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "opportunity",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    job_title = table.Column<string>(nullable: false),
                    job_description = table.Column<string>(nullable: true),
                    what_you_gain = table.Column<string>(nullable: true),
                    about_team = table.Column<string>(nullable: true),
                    number_of_people = table.Column<string>(nullable: true),
                    start_date = table.Column<DateTime>(nullable: false),
                    end_date = table.Column<DateTime>(nullable: false),
                    commitment_time = table.Column<string>(nullable: true),
                    agency = table.Column<string>(nullable: true),
                    contact_person_name = table.Column<string>(nullable: true),
                    contact_person_phone = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    skills = table.Column<string>(nullable: true),
                    additional_info = table.Column<string>(nullable: true),
                    security_clearance = table.Column<string>(name: "security_clearance ", nullable: true),
                    modifed = table.Column<DateTime>(nullable: true),
                    created = table.Column<DateTime>(nullable: false),
                    created_by = table.Column<int>(nullable: false),
                    modified_by = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opportunity", x => x.id);
                    table.ForeignKey(
                        name: "opportunity_created_by_user_id_fkey",
                        column: x => x.created_by,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "opportunity_modified_by_user_id_fkey",
                        column: x => x.modified_by,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "opportunity_assessor",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    opportunity_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: true),
                    email_address = table.Column<string>(type: "character varying", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opportunity_assessor", x => x.id);
                    table.ForeignKey(
                        name: "opportunity_assessor_opportunity_id_fkey",
                        column: x => x.opportunity_id,
                        principalTable: "opportunity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "opportunity_assessor_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "opportunity_clarification_question",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    opportunity_id = table.Column<int>(nullable: false),
                    question = table.Column<string>(type: "character varying", nullable: false),
                    answer = table.Column<string>(type: "character varying", nullable: false),
                    published_at = table.Column<DateTime>(nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opportunity_clarification_question", x => x.id);
                    table.ForeignKey(
                        name: "opportunity_clarification_question_opportunity_id_fkey",
                        column: x => x.opportunity_id,
                        principalTable: "opportunity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "opportunity_clarification_question_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "opportunity_history",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    opportunity_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    edited_at = table.Column<DateTime>(nullable: false),
                    data = table.Column<string>(type: "json", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opportunity_history", x => x.id);
                    table.ForeignKey(
                        name: "opportunity_history_opportunity_id_fkey",
                        column: x => x.opportunity_id,
                        principalTable: "opportunity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "opportunity_history_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "opportunity_response",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    data = table.Column<string>(type: "json", nullable: false),
                    opportunity_id = table.Column<int>(nullable: false),
                    supplier_code = table.Column<long>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false),
                    withdrawn_at = table.Column<DateTime>(nullable: true),
                    submitted_at = table.Column<DateTime>(nullable: true),
                    updated_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opportunity_response", x => x.id);
                    table.ForeignKey(
                        name: "opportunity_response_opportunity_id_fkey",
                        column: x => x.opportunity_id,
                        principalTable: "opportunity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "opportunity_response_contact",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    opportunity_id = table.Column<int>(nullable: false),
                    supplier_code = table.Column<long>(nullable: false),
                    email_address = table.Column<string>(type: "character varying", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opportunity_response_contact", x => x.id);
                    table.ForeignKey(
                        name: "opportunity_response_opportunity_contact_id_fkey",
                        column: x => x.opportunity_id,
                        principalTable: "opportunity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "opportunity_response_download",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    opportunity_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    created_at = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opportunity_response_download", x => x.id);
                    table.ForeignKey(
                        name: "opportunity_response_download_opportunity_id_fkey",
                        column: x => x.opportunity_id,
                        principalTable: "opportunity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "opportunity_response_download_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "opportunity_skill",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    opportunity_id = table.Column<int>(nullable: false),
                    skill_key = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("opportunity_skill_pkey", x => x.id);
                    table.ForeignKey(
                        name: "opportunity_skill_opportunity_id_fkey",
                        column: x => x.opportunity_id,
                        principalTable: "opportunity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "opportunity_user",
                columns: table => new
                {
                    opportunity_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("opportunity_user_pkey", x => new { x.opportunity_id, x.user_id });
                    table.ForeignKey(
                        name: "opportunity_user_opportunity_id_fkey",
                        column: x => x.opportunity_id,
                        principalTable: "opportunity",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "opportunity_user_user_id_fkey",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "key_value_key_key",
                table: "key_value",
                column: "key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_key_value_updated_at",
                table: "key_value",
                column: "updated_at");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_created_by",
                table: "opportunity",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_end_date",
                table: "opportunity",
                column: "end_date");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_job_title",
                table: "opportunity",
                column: "job_title");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_modified_by",
                table: "opportunity",
                column: "modified_by");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_start_date",
                table: "opportunity",
                column: "start_date");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_assessor_opportunity_id",
                table: "opportunity_assessor",
                column: "opportunity_id");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_assessor_user_id",
                table: "opportunity_assessor",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_clarification_question_opportunity_id",
                table: "opportunity_clarification_question",
                column: "opportunity_id");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_clarification_question_published_at",
                table: "opportunity_clarification_question",
                column: "published_at");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_clarification_question_user_id",
                table: "opportunity_clarification_question",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_history_edited_at",
                table: "opportunity_history",
                column: "edited_at");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_history_opportunity_id",
                table: "opportunity_history",
                column: "opportunity_id");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_history_user_id",
                table: "opportunity_history",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_response_created_at",
                table: "opportunity_response",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_response_opportunity_id",
                table: "opportunity_response",
                column: "opportunity_id");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_response_submitted_at",
                table: "opportunity_response",
                column: "submitted_at");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_response_updated_at",
                table: "opportunity_response",
                column: "updated_at");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_response_contact_opportunity_id",
                table: "opportunity_response_contact",
                column: "opportunity_id");

            migrationBuilder.CreateIndex(
                name: "ix_opportunity_response_download_created_at",
                table: "opportunity_response_download",
                column: "created_at");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_response_download_opportunity_id",
                table: "opportunity_response_download",
                column: "opportunity_id");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_response_download_user_id",
                table: "opportunity_response_download",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_skill_opportunity_id",
                table: "opportunity_skill",
                column: "opportunity_id");

            migrationBuilder.CreateIndex(
                name: "IX_opportunity_user_user_id",
                table: "opportunity_user",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_email_address",
                table: "user",
                column: "email_address",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "key_value");

            migrationBuilder.DropTable(
                name: "opportunity_assessor");

            migrationBuilder.DropTable(
                name: "opportunity_clarification_question");

            migrationBuilder.DropTable(
                name: "opportunity_history");

            migrationBuilder.DropTable(
                name: "opportunity_response");

            migrationBuilder.DropTable(
                name: "opportunity_response_contact");

            migrationBuilder.DropTable(
                name: "opportunity_response_download");

            migrationBuilder.DropTable(
                name: "opportunity_skill");

            migrationBuilder.DropTable(
                name: "opportunity_user");

            migrationBuilder.DropTable(
                name: "opportunity");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropSequence(
                name: "key_value_id_seq");

            migrationBuilder.DropSequence(
                name: "opportunity_assessor_id_seq");

            migrationBuilder.DropSequence(
                name: "opportunity_history_id_seq");

            migrationBuilder.DropSequence(
                name: "opportunity_question_id_seq");

            migrationBuilder.DropSequence(
                name: "opportunity_response_answer_id_seq");

            migrationBuilder.DropSequence(
                name: "opportunity_response_contact_id_seq");

            migrationBuilder.DropSequence(
                name: "opportunity_response_download_id_seq");
        }
    }
}
