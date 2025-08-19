import React from 'react';
import RegisterForm from './components/ClientManagementForm';

const App: React.FC = () => {
    return (
        <div className="App">
            <h1>Client Management</h1>
            <RegisterForm />
        </div>
    );
};

export default App;