# Observer Pattern

## Interface Interaction

`ISubject`s broacast events with `Notify(IEvent e)` which are recieved by `IObserver`'s `OnNotify(IEvent e)` to act upon the event and get the state of the ISubject.

### Link
`ISubject` can attach to `IObserver`s

`IObserver`s can observe an `ISubject`

### Unlink

`ISubject` can detach an `IObserver`s

`IObserver`s can detach from an `ISubject`

## Concrete Implementation

`Teacher` implements `ISubject`
`Student` implements `IObserver`
`TeacherUpdatedEvent` implements `IEvent`
