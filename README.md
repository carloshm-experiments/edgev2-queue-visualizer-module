# Azure IoT Edge Monitoring Module

This module will monitor all messages passed insight the edge device and expose those as json object through an REST endpoint.

## Usage

the simplest way to use this is to leverage the prebuilt module from Docker hub `dariuszparys/monitor-module:latest`. Include it into your module deployment and define a route to catch all traffic. In the prebuilt module this would be

```json
"routes": {
    "monitorAll": "FROM /* INTO BrokeredEndpoint(\"/modules/monitor-module/inputs/input1\")"
},
```

## Configuration files

In this project I've included to configuration files. `deployment.json` is basically an example you can use out of the box which will leverage the temperature simulator module from the Azure IoT Edge tutorials and monitor them.

The other configuration file is for my CI/CD environment and shouldn't be used.

## Current Implementation

### Message Routing

All messages routed to the Monitoring Module will be processed and stored in-memory. The current amount of messages cached are the latest 20. In `deployment.json` the default route is set to catch all messages going through the EdgeHub. You can constrain the route to catch just specific modules.

### Web Api

The in-memory structure is exposed as JSON array through the message endpoint `queues`. Currently the data structure just exposes the properties `ModuleId` and `MessageReceived` which is the actual JSON payload of the message itself.

When you start the module the endpoint is http://localhost:4243/queues.

### Monitoring Website

Included in this module is a Vue.js based static website consuming the Web API endpoint and displaying it as a grid. It doesn't have any kind of refreshing mechanism.

Monitoring endpoint is http://localhost:4243/monitor/index.html

## Todos

This is just a starting point. There are plenty of areas to invest more time and make the experience of this module better. Things like

- Customizable in-memory storage
- Optional storage into docker host file system or any other storage mechanism
- Monitoring Web App to support nice layout for instance display all different participating modules in its own area make that switchable and configurable.
- Remove any hardcoded dependencies.
- Switch to Vue.js minimal production framework

Ping me for any feedback or just PR changes.