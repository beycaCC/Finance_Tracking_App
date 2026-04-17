# Finance_Tracking_App

Database Schema Design (https://lucid.app/lucidchart/c01dda02-b78a-4e59-8d21-d39df537b8d8/edit?viewport_loc=-386%2C-533%2C1021%2C1174%2C0_0&invitationId=inv_de2db249-ea57-4f32-a3bf-0d93fa376275)

# 💰 Money Tracking App — Backend

A personal finance and expense tracking backend designed to help users manage accounts, track monthly spending, set budgets, and analyze expenses across categories and currencies.

This repository contains the **backend API**, built with modern .NET technologies and designed to support mobile or web clients.

---

## 🎯 Project Vision

The goal of this project is to build a **clean, scalable, and finance‑safe backend** that allows users to:

- Track balances **per account** (checking, savings, credit, brokerage, etc.)
- Monitor **monthly expenses** (no lifetime totals for now)
- Set **monthly budgets**, including multi‑currency inputs
- Categorize expenses and track remaining budget per category
- Prepare for future features such as analytics and yearly summaries

The project emphasizes **correct data modeling**, **explicit relationships**, and **long‑term maintainability**.

---

## 🧱 Tech Stack

### Backend
- **ASP.NET Core Web API**
- **C#**
- **.NET 8 (LTS)**
- **Entity Framework Core (EF Core)** — Code‑First with Migrations
- **Relational Database** (PostgreSQL recommended; final choice configurable)

### Frontend
- Not implemented yet  
- Backend is designed to be frontend‑agnostic  
- Intended to support iOS (Swift / SwiftUI) or cross‑platform clients (React Native)

---

## 🏗️ Architecture Overview

This project follows an **enterprise‑style backend architecture**, similar to Spring Boot applications.

