import React from 'react';
import './App.css';
import ReminderPage from "./Reminders/ReminderPage";

function App() {
    return (
        <div className="App">
            <header className="App-header">
                Reminders
            </header>
            <ReminderPage></ReminderPage>
        </div>
    );
}

export default App;
