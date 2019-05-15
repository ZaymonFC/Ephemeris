# Project Ephmeris

## Motivations & Ambitions ⚡️
- To __allow the development__ of some personal projects which follow `Command Query Responsibility Segregation` I am in need of a simple message queueing system.
- If the client application crashes, I need a low overhead way to ensure processing of unprocessed commands and events.
- I need a simple bus to buffer and store commands and events.
- I would like to use an in memory data store like Redis to leverage redis Queues and Sets.
- I would like a simple API/mechanism to acknowledge that I am done processing an event.
- The API should be simple and intuitive.
- At this stage I do not require distributed transactions or a competing consumer model.

I looked at options like HangFire but the paid requirement to run the solution over Redis along wit a lack of **Functional First** support deterred me.

## Specification
#### Activity Diagram - High Level Flow
![Activity Diagram](/Diagrams/Activity.svg)

## Roadmap
- [ ] Create diagrams
    - [x] Activity
    - [ ] C4 - System
- [ ] Define interface and types
- [ ] Create an interface for Redis
- [ ] Build out the core event processor
- [ ] Add batching support

### Why the Name
1. This project is a __proof of concept__ and therefore most likely to be ephemeral in the literal sense. 
2. It sounds **cool**
