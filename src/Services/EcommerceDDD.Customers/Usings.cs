global using Marten;
global using System.Net;
global using Marten.Events;
global using Newtonsoft.Json;
global using Marten.Events.Projections;
global using Marten.Events.Aggregation;
global using EcommerceDDD.Core.Domain;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.Extensions.Options;
global using EcommerceDDD.Core.Exceptions;
global using EcommerceDDD.Customers.Domain;
global using EcommerceDDD.Core.Persistence;
global using EcommerceDDD.Core.Infrastructure;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Authentication;
global using EcommerceDDD.Core.CQRS.QueryHandling;
global using EcommerceDDD.Customers.Domain.Events;
global using System.ComponentModel.DataAnnotations;
global using EcommerceDDD.Core.Infrastructure.Http;
global using EcommerceDDD.Core.Infrastructure.Marten;
global using EcommerceDDD.Customers.Domain.Commands;
global using EcommerceDDD.Core.CQRS.CommandHandling;
global using EcommerceDDD.Core.Infrastructure.WebApi;
global using EcommerceDDD.Core.Infrastructure.Identity;
global using EcommerceDDD.Core.Infrastructure.Integration;
global using EcommerceDDD.Customers.API.Controllers.Requests;
global using EcommerceDDD.Customers.Infrastructure.Projections;
global using EcommerceDDD.Customers.Application.GettingCreditLimit;
global using EcommerceDDD.Customers.Application.RegisteringCustomer;
global using EcommerceDDD.Customers.Api.Application.RegisteringCustomer;
global using EcommerceDDD.Customers.Application.GettingCustomerEventHistory;
global using EcommerceDDD.Customers.Api.Application.GettingCustomerDetails;