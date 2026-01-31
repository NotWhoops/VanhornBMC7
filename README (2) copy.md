# Project: “Device Checkout API” (IT Lab Inventory)

## Goal
> Build an ASP.NET Core Web API that simulates a backend for a small IT lab where students can check out devices (laptops, tablets, hotspots) to students.


## 1. Requirements
- Create a new ASP.NET Core Web API (.NET) project

- Use Controllers (not minimal APIs)

- No database: store data in in-memory lists inside services


## 2. Models

**Device Model Fields:**
- Id: `int`
- Name: `string` — ex: “Dell Latitude 5420”
- Type: `string` — “Laptop”, “Tablet”, “Hotspot”
- SerialNumber: `string`
- IsCheckedOut: `bool`

**Student Model Fields:**
- Id: `int`
- FullName: `string`
- Email: `string`
- DeviceCheckedOutId: `int?` — null if none


## 3. Endpoints
### DevicesController

**Get all devices that are NOT checked out**
+ GET `/api/devices/available`

**Add a new device**
- POST `/api/devices`

**Update device details**
- PUT `/api/devices/{id}`

**Change checkout status of a device**
- PATCH `/api/devices/{id}/checkout`
toggles IsCheckedOut OR accepts a body like `{ "isCheckedOut": true }`

### StudentsController

**Retrieve all students**
- GET `/api/students`

**Add a new student**
- POST `/api/students`

**Update student details**
- PUT `/api/students/{id}`

**Remove a student by ID**
- DELETE `/api/students/{id}`

## 4. Service Layer (Core of the Evaluation Practice)
> Create two services:

