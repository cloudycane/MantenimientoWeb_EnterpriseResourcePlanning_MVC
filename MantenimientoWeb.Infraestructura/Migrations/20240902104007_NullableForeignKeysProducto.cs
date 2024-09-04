﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenimientoWeb.Infraestructura.Migrations
{
    public partial class NullableForeignKeysProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Clasificaciones_ClasificacionId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Empaquetamientos_EmpaquetamientoId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Transportes_TransporteId",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "TransporteId",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EmpaquetamientoId",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClasificacionId",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Clasificaciones_ClasificacionId",
                table: "Productos",
                column: "ClasificacionId",
                principalTable: "Clasificaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Empaquetamientos_EmpaquetamientoId",
                table: "Productos",
                column: "EmpaquetamientoId",
                principalTable: "Empaquetamientos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Transportes_TransporteId",
                table: "Productos",
                column: "TransporteId",
                principalTable: "Transportes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Clasificaciones_ClasificacionId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Empaquetamientos_EmpaquetamientoId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Transportes_TransporteId",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "TransporteId",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmpaquetamientoId",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClasificacionId",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Clasificaciones_ClasificacionId",
                table: "Productos",
                column: "ClasificacionId",
                principalTable: "Clasificaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Empaquetamientos_EmpaquetamientoId",
                table: "Productos",
                column: "EmpaquetamientoId",
                principalTable: "Empaquetamientos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Transportes_TransporteId",
                table: "Productos",
                column: "TransporteId",
                principalTable: "Transportes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}