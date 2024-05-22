﻿// <auto-generated />
using System;
using CompanyPMO_.NET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CompanyPMO_.NET.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240521080039_added-entities-foreign-keys-to-timeline")]
    partial class addedentitiesforeignkeystotimeline
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CompanyPMO_.NET.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("address_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("country");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("postal_code");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("state");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("street_address");

                    b.HasKey("AddressId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Changelog", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("log_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LogId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer")
                        .HasColumnName("entity_id");

                    b.Property<string>("EntityType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("entity_type");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified");

                    b.Property<string>("NewData")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("new_data");

                    b.Property<string>("OldData")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("old_data");

                    b.Property<string>("Operation")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("operation");

                    b.HasKey("LogId");

                    b.ToTable("changelog");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("company_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CompanyId"));

                    b.Property<int?>("AddedById")
                        .HasColumnType("integer")
                        .HasColumnName("added_by_id");

                    b.Property<int?>("AddressId")
                        .HasColumnType("integer")
                        .HasColumnName("address_id");

                    b.Property<int?>("CeoUserId")
                        .HasColumnType("integer")
                        .HasColumnName("ceo_user_id");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("text")
                        .HasColumnName("contact_email");

                    b.Property<string>("ContactPhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("contact_phone_number");

                    b.Property<DateTime>("LatestProjectCreation")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("latest_project_creation");

                    b.Property<string>("Logo")
                        .HasColumnType("text")
                        .HasColumnName("logo");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("CompanyId");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gender");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_login");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<bool>("LockedEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTime?>("LockedUntil")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("locked_until");

                    b.Property<int>("LoginAttempts")
                        .HasColumnType("integer")
                        .HasColumnName("login_attempts");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<DateTime?>("PasswordVerified")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("password_verified");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("text")
                        .HasColumnName("profile_picture");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("integer")
                        .HasColumnName("supervisor_id");

                    b.Property<int>("TierId")
                        .HasColumnType("integer")
                        .HasColumnName("tier_id");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("SupervisorId");

                    b.HasIndex("TierId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.EmployeeIssue", b =>
                {
                    b.Property<int>("RelationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("relation_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RelationId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<int>("IssueId")
                        .HasColumnType("integer")
                        .HasColumnName("issue_id");

                    b.HasKey("RelationId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("IssueId");

                    b.ToTable("employeeissues");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.EmployeeProject", b =>
                {
                    b.Property<int>("RelationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("relation_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RelationId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer")
                        .HasColumnName("project_id");

                    b.HasKey("RelationId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("employeeprojects");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.EmployeeTask", b =>
                {
                    b.Property<int>("RelationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("relation_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RelationId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<int>("TaskId")
                        .HasColumnType("integer")
                        .HasColumnName("task_id");

                    b.HasKey("RelationId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaskId");

                    b.ToTable("employeetasks");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("image_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ImageId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<int>("EntityId")
                        .HasColumnType("integer")
                        .HasColumnName("entity_id");

                    b.Property<string>("EntityType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("entity_type");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<string>("PublicId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("public_id");

                    b.Property<int>("UploaderId")
                        .HasColumnType("integer")
                        .HasColumnName("uploader_id");

                    b.HasKey("ImageId");

                    b.HasIndex("EntityId");

                    b.ToTable("images");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Issue", b =>
                {
                    b.Property<int>("IssueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("issue_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IssueId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime?>("ExpectedDeliveryDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("expected_delivery_date");

                    b.Property<DateTime?>("Finished")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("finished");

                    b.Property<int>("IssueCreatorId")
                        .HasColumnType("integer")
                        .HasColumnName("issue_creator_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime?>("StartedWorking")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("started_working");

                    b.Property<int>("TaskId")
                        .HasColumnType("integer")
                        .HasColumnName("task_id");

                    b.HasKey("IssueId");

                    b.HasIndex("IssueCreatorId");

                    b.HasIndex("TaskId");

                    b.ToTable("issues");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("notification_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("NotificationId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("integer")
                        .HasColumnName("receiver_id");

                    b.Property<int?>("SenderId")
                        .HasColumnType("integer")
                        .HasColumnName("sender_id");

                    b.HasKey("NotificationId");

                    b.ToTable("notifications");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("project_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProjectId"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime?>("ExpectedDeliveryDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("expected_delivery_date");

                    b.Property<DateTime?>("Finished")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("finished");

                    b.Property<DateTime>("LatestTaskCreation")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("latest_task_creation");

                    b.Property<string>("Lifecycle")
                        .HasColumnType("text")
                        .HasColumnName("lifecycle");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Priority")
                        .HasColumnType("integer")
                        .HasColumnName("priority");

                    b.Property<int>("ProjectCreatorId")
                        .HasColumnType("integer")
                        .HasColumnName("project_creator_id");

                    b.Property<DateTime?>("StartedWorking")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("started_working");

                    b.HasKey("ProjectId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProjectCreatorId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.ResetPasswordRequest", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("request_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RequestId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<Guid>("RequestGuid")
                        .HasColumnType("uuid")
                        .HasColumnName("request_guid");

                    b.Property<int?>("Token")
                        .HasColumnType("integer")
                        .HasColumnName("token");

                    b.Property<DateTime?>("TokenExpiry")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("token_expiry");

                    b.HasKey("RequestId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("resetpasswordrequests");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("task_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TaskId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime?>("ExpectedDeliveryDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("expected_delivery_date");

                    b.Property<DateTime?>("Finished")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("finished");

                    b.Property<DateTime>("LatestIssueCreation")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("latest_issue_creation");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer")
                        .HasColumnName("project_id");

                    b.Property<DateTime?>("StartedWorking")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("started_working");

                    b.Property<int>("TaskCreatorId")
                        .HasColumnType("integer")
                        .HasColumnName("task_creator_id");

                    b.HasKey("TaskId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TaskCreatorId");

                    b.ToTable("tasks");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Tier", b =>
                {
                    b.Property<int>("TierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tier_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TierId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("Duty")
                        .HasColumnType("text")
                        .HasColumnName("duty");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("TierId");

                    b.ToTable("tiers");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Timeline", b =>
                {
                    b.Property<int>("TimelineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("timeline_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TimelineId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<string>("Event")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("event");

                    b.Property<int?>("IssueId")
                        .HasColumnType("integer")
                        .HasColumnName("issue_id");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("integer")
                        .HasColumnName("project_id");

                    b.Property<int?>("TaskId")
                        .HasColumnType("integer")
                        .HasColumnName("task_id");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.HasKey("TimelineId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("IssueId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TaskId");

                    b.ToTable("timelines");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("FirstName")
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gender");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_login");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<string>("ProfilePicture")
                        .HasColumnType("text")
                        .HasColumnName("profile_picture");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Workload", b =>
                {
                    b.Property<int>("WorkloadId")
                        .HasColumnType("integer")
                        .HasColumnName("workload_id");

                    b.Property<int?>("AssignedIssues")
                        .HasColumnType("integer")
                        .HasColumnName("assigned_issues");

                    b.Property<int?>("AssignedProjects")
                        .HasColumnType("integer")
                        .HasColumnName("assigned_projects");

                    b.Property<int?>("AssignedTasks")
                        .HasColumnType("integer")
                        .HasColumnName("assigned_tasks");

                    b.Property<int?>("CompletedIssues")
                        .HasColumnType("integer")
                        .HasColumnName("completed_issues");

                    b.Property<int?>("CompletedProjects")
                        .HasColumnType("integer")
                        .HasColumnName("completed_projects");

                    b.Property<int?>("CompletedTasks")
                        .HasColumnType("integer")
                        .HasColumnName("completed_tasks");

                    b.Property<int?>("CreatedIssues")
                        .HasColumnType("integer")
                        .HasColumnName("created_issues");

                    b.Property<int?>("CreatedProjects")
                        .HasColumnType("integer")
                        .HasColumnName("created_projects");

                    b.Property<int?>("CreatedTasks")
                        .HasColumnType("integer")
                        .HasColumnName("created_tasks");

                    b.Property<int?>("OverdueIssues")
                        .HasColumnType("integer")
                        .HasColumnName("overdue_issues");

                    b.Property<int?>("OverdueProjects")
                        .HasColumnType("integer")
                        .HasColumnName("overdue_projects");

                    b.Property<int?>("OverdueTasks")
                        .HasColumnType("integer")
                        .HasColumnName("overdue_tasks");

                    b.Property<string>("WorkloadSum")
                        .HasColumnType("text")
                        .HasColumnName("workload_sum");

                    b.HasKey("WorkloadId");

                    b.ToTable("workload");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Employee", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Employee", "Supervisor")
                        .WithMany("Employees")
                        .HasForeignKey("SupervisorId");

                    b.HasOne("CompanyPMO_.NET.Models.Tier", "Tier")
                        .WithMany()
                        .HasForeignKey("TierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Supervisor");

                    b.Navigation("Tier");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.EmployeeIssue", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Issue", null)
                        .WithMany()
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.EmployeeProject", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.EmployeeTask", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Task", null)
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Image", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Company", "Company")
                        .WithMany("Images")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Project", "Project")
                        .WithMany("Images")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Task", "Task")
                        .WithMany("Images")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Project");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Issue", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Employee", "IssueCreator")
                        .WithMany()
                        .HasForeignKey("IssueCreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Task", "Task")
                        .WithMany("Issues")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IssueCreator");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Project", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Company", "Company")
                        .WithMany("Projects")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Employee", "ProjectCreator")
                        .WithMany()
                        .HasForeignKey("ProjectCreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("ProjectCreator");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.ResetPasswordRequest", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Task", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Project", "Project")
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Employee", "TaskCreator")
                        .WithMany()
                        .HasForeignKey("TaskCreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("TaskCreator");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Timeline", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyPMO_.NET.Models.Issue", "Issue")
                        .WithMany()
                        .HasForeignKey("IssueId");

                    b.HasOne("CompanyPMO_.NET.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.HasOne("CompanyPMO_.NET.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId");

                    b.Navigation("Employee");

                    b.Navigation("Issue");

                    b.Navigation("Project");

                    b.Navigation("Task");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Workload", b =>
                {
                    b.HasOne("CompanyPMO_.NET.Models.Employee", "Employee")
                        .WithOne("Workload")
                        .HasForeignKey("CompanyPMO_.NET.Models.Workload", "WorkloadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Company", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Images");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Employee", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Workload")
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Project", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("CompanyPMO_.NET.Models.Task", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Issues");
                });
#pragma warning restore 612, 618
        }
    }
}
