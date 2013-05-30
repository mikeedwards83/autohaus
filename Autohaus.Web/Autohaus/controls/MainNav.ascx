<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MainNav.ascx.cs" Inherits="Autohaus.Web.UI.Controls.MainNav" %>
<%@ Register namespace="Glass.Mapper.Sc.Razor.Web.Ui" assembly="Glass.Mapper.Sc.Razor" tagPrefix="gls" %>
<%@ Import Namespace="Autohaus.Data.Models" %>
<%--<ul class="nav">
    <% foreach (NavigationItem navItem in NavigationItems)
       { %>
        <% if (navItem.SubItems.Any())
           { %>
            <% if (navItem.IsActive)
               { %>
    <li class="dropdown active">
    <% }
               else
               { %>
    <li class="dropdown">
        <% } %>
        <a href="#" class="dropdown-toggle" data-toggle="dropdown"><%= navItem.NavTitle %> <b class="caret"></b></a>
        <ul class="getstarted-menu" style="display: none">
            <li>
                <a href="#" class="getstarted" data-placement="bottom" data-toggle="popover" data-content="<%= navItem.Text %>" data-original-title="<%= navItem.Title %>"></a>
            </li>
        </ul>
        <ul class="dropdown-menu">
            <% foreach (NavigationItem subNavItem in navItem.SubItems)
               { %>
                <% if (subNavItem.IsActive)
                   { %>
            <li class="active">
            <% }
                   else
                   { %>
            <li>
                <% } %>
                <a href="<%= subNavItem.Url %>"><%= subNavItem.NavTitle %></a>
            </li>
                <% } %>
                    </ul>
    </li>
        <% }
           else
           { %>
            <% if (navItem.IsActive)
               { %>
    <li class="active">
    <% }
               else
               { %>
    <li> <% } %>
        <a href="<%= navItem.Url %>"><%= navItem.NavTitle %></a>
    </li>
        <% } %>
    <% } %>
                </ul>--%>

<gls:GlassRazorControl runat="server" Path="/sitecore/layout/Glass Razor/Controls/MainNav"/>