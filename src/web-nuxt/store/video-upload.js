const initState = () => ({
  active: false,
})

export const state = initState

export const mutations = {
  toggleActivity(state) {
    state.active = !state.active
    if(!state.active){
      Object.assign(state, initState())
    }
  },
  reset(state){
    Object.assign(state, initState())
  }
}

export const actions = {

}
