using GraphQL;
using GraphQL.Types;
using GraphQLProject.Data;
using GraphQLProject.Interfaces;
using GraphQLProject.Mutation;
using GraphQLProject.Query;
using GraphQLProject.Repositories;
using GraphQLProject.Schema;
using GraphQLProject.Type;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMenuRepository, MenuRepository>();

builder.Services.AddScoped<MenuType>();
builder.Services.AddScoped<MenuQuery>();
builder.Services.AddScoped<MenuMutation>();
builder.Services.AddScoped<ISchema, MenuSchema>();

builder.Services.AddGraphQL(options => {
    options.AddAutoSchema<ISchema>();
    options.AddSystemTextJson();
});

builder.Services.AddDbContext<GraphQLDbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseGraphQL<ISchema>();
app.MapControllers();
app.UseGraphQLPlayground("/", new() {
    GraphQLEndPoint = "/graphql",
    SubscriptionsEndPoint = "/graphql"
});

app.Run();

