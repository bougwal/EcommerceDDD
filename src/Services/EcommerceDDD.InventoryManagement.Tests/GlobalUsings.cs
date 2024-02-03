global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.Infrastructure.Marten.Tests;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Core.Testing;
global using EcommerceDDD.InventoryManagement.API.Controllers;
global using EcommerceDDD.InventoryManagement.API.Controllers.Requests;
global using EcommerceDDD.InventoryManagement.Application.CheckingQuantityInStock;
global using EcommerceDDD.InventoryManagement.Application.DecreasingQuantityInStock;
global using EcommerceDDD.InventoryManagement.Application.EnteringProductInStock;
global using EcommerceDDD.InventoryManagement.Application.GettingInventoryStockUnitEventHistory;
global using EcommerceDDD.InventoryManagement.Domain;
global using EcommerceDDD.InventoryManagement.Domain.Commands;
global using EcommerceDDD.InventoryManagement.Domain.Events;
global using EcommerceDDD.InventoryManagement.Infrastructure.Projections;
global using FluentAssertions;
global using Marten;
global using Microsoft.AspNetCore.Mvc;
global using NSubstitute;
global using Xunit;
