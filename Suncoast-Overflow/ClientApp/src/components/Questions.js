import React, { Component } from 'react'

export class Questions extends Component {
    static displayName = Questions.name

    // constructor(props) {
    //   super(props)
    //   this.state = {
    //     title: '',
    //     text: ''
    //   }
    // }
    // updateTitle = event => {
    //   this.setState({
    //     title: event.target.value
    //   })
    // }

    render() {
        return (
            <div>
                <div className="Header">
                    <textarea
                        id="story"
                        name="story"
                        rows="2"
                        cols="40"
                        placeholder="Title"
                    // onChange={this.updateTitle}
                    />
                    <button>Ask Question</button>
                </div>

                <div className="Titles">
                    <div className="Questions">
                        <textarea
                            id="story"
                            name="story"
                            rows="10"
                            cols="40"
                            placeholder="Body"
                        />

                        <div className="CreatedTimeAndAuthor">
                            <div>Modified 2 minutes ago</div>
                            <input type="text" placeholder="Author" />
                        </div>
                    </div>
                </div>
            </div>
        )
    }
}

export default Questions