global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Core.Domain;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Core.Infrastructure;
global using EcommerceDDD.Core.Infrastructure.Identity;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Core.Infrastructure.Marten;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Core.Persistence;
global using EcommerceDDD.InventoryManagement.API.Controllers.Requests;
global using EcommerceDDD.InventoryManagement.Application.CheckingQuantityInStock;
global using EcommerceDDD.InventoryManagement.Application.GettingInventoryStockUnitEventHistory;
global using EcommerceDDD.InventoryManagement.Domain;
global using EcommerceDDD.InventoryManagement.Domain.Commands;
global using EcommerceDDD.InventoryManagement.Domain.Events;
global using EcommerceDDD.InventoryManagement.Infrastructure.Projections;
global using EcommerceDDD.ProductCatalog.Infrastructure.Extensions;
global using Marten;
global using Marten.Events;
global using Marten.Events.Aggregation;
global using Marten.Events.Projections;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Mvc;
global using Newtonsoft.Json;
global using Polly;
global using System.ComponentModel.DataAnnotations;
