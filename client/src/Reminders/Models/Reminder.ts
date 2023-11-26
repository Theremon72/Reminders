export interface Reminder {
    id: number,
    dateCreated: Date,
    date: Date,
    snoozeInterval: Date,
    ReReminderInterval: Date,
    DaySchedule: number,
    note: string
    //location: Location
}