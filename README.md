# Project Ephmeris

## Motivations & Ambitions ⚡️
To allow the development of some personal projects which follow `Command Query Responsibility Segregation` I am in need of a simple message queueing system.

I looked at options like HangFire but the paid options to run the solution over Redis along wit a lack of **Functional First** support deterred me.

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
